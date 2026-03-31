using NUnit.Framework;

[assembly: LevelOfParallelism(1)]


namespace MassTransit.RabbitMqTransport.Tests;

using System;
using System.Threading.Tasks;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Images;
using Testing;
using Testcontainers.RabbitMq;


[SetUpFixture]
public class RabbitMqTestSetUpFixture
{
    static RabbitMqContainer _container;
    static IFutureDockerImage _image;

    public static Uri HostAddress { get; private set; }
    public static string Username { get; private set; }
    public static string Password { get; private set; }
    public static int ManagementPort { get; private set; }

    [OneTimeSetUp]
    public async Task Before_any()
    {
        var dockerfileDir = FindDockerfileDirectory();

        _image = new ImageFromDockerfileBuilder()
            .WithDockerfileDirectory(dockerfileDir)
            .WithDockerfile("Dockerfile.rabbitmq")
            .WithName("masstransit-rabbitmq-test")
            .WithCleanUp(false)
            .Build();

        await _image.CreateAsync();

        _container = new RabbitMqBuilder(_image.FullName)
            .WithUsername("guest")
            .WithPassword("guest")
            .WithPortBinding(15672, true)
            .Build();

        await _container.StartAsync();

        Username = "guest";
        Password = "guest";

        var host = _container.Hostname;
        var port = _container.GetMappedPublicPort(5672);

        ManagementPort = _container.GetMappedPublicPort(15672);
        HostAddress = new Uri($"rabbitmq://{host}:{port}/test/");

        await CreateVirtualHost(host, ManagementPort);
    }

    public static RabbitMqTestHarness CreateHarness(string inputQueueName = null)
    {
        var harness = new RabbitMqTestHarness(inputQueueName)
        {
            HostAddress = HostAddress,
            Username = Username,
            Password = Password,
            ManagementPort = ManagementPort
        };
        return harness;
    }

    public static void ConfigureTransportOptions(RabbitMqTransportOptions options)
    {
        options.Host = HostAddress.Host;
        options.Port = (ushort)HostAddress.Port;
        options.VHost = "test";
        options.User = Username;
        options.Pass = Password;
        options.ManagementPort = (ushort)ManagementPort;
    }

    [OneTimeTearDown]
    public async Task After_all()
    {
        if (_container != null)
            await _container.DisposeAsync();
    }

    static string FindDockerfileDirectory()
    {
        var dir = AppContext.BaseDirectory;
        while (dir != null)
        {
            if (System.IO.File.Exists(System.IO.Path.Combine(dir, "Dockerfile.rabbitmq")))
                return dir;
            dir = System.IO.Path.GetDirectoryName(dir);
        }

        throw new InvalidOperationException("Could not find directory containing Dockerfile.rabbitmq");
    }

    async Task CreateVirtualHost(string host, int managementPort)
    {
        try
        {
            using var client = new System.Net.Http.HttpClient();
            var byteArray = System.Text.Encoding.ASCII.GetBytes($"{Username}:{Password}");
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Convert.ToBase64String(byteArray));

            var requestUri = new UriBuilder("http", host, managementPort, "api/vhosts/test").Uri;
            await client.PutAsync(requestUri,
                new System.Net.Http.StringContent("{}", System.Text.Encoding.UTF8, "application/json"));
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
        }
    }
}
