# MassTransit

MassTransit provides a developer-focused, modern platform for creating distributed applications without complexity.

- First class testing support
- Write once, then deploy using RabbitMQ, Azure Service Bus, and SQL transports
- Observability via Open Telemetry (OTEL)
- Fully-supported, widely-adopted, a complete end-to-end solution

## Documentation

Get started by [reading through the documentation](https://masstransit-project.com/).

## Build Status

| Branch  |                                                                                              Status                                                                                              |
|---------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
| master  |  [![master](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml/badge.svg?branch=master&event=push)](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml)  |
| develop | [![develop](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml/badge.svg?branch=develop&event=push)](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml) |

## MassTransit NuGet Packages

[![alt MassTransit](https://img.shields.io/nuget/v/MassTransit.svg "MassTransit")](https://nuget.org/packages/MassTransit/)

* [MassTransit](https://nuget.org/packages/MassTransit/)
* [MassTransit.Abstractions](https://www.nuget.org/packages/MassTransit.Abstractions/)

### Transports

* [MassTransit.Azure.ServiceBus.Core](https://nuget.org/packages/MassTransit.Azure.ServiceBus.Core/)
    * [MassTransit.WebJobs.ServiceBus](https://nuget.org/packages/MassTransit.WebJobs.ServiceBus/)
    * [MassTransit.WebJobs.EventHubs](https://nuget.org/packages/MassTransit.WebJobs.EventHubs/)
* [MassTransit.RabbitMQ](https://nuget.org/packages/MassTransit.RabbitMQ/)
* [MassTransit.SqlTransport.PostgreSQL](https://nuget.org/packages/MassTransit.SqlTransport.PostgreSQL/)
* [MassTransit.SqlTransport.SqlServer](https://nuget.org/packages/MassTransit.SqlTransport.SqlServer/)
* **Riders**
    * [MassTransit.EventHub](https://nuget.org/packages/MassTransit.EventHub/)
    * [MassTransit.Kafka](https://nuget.org/packages/MassTransit.Kafka/)

### Saga Persistence

* [MassTransit.Azure.Cosmos](https://nuget.org/packages/MassTransit.Azure.Cosmos/)
* [MassTransit.Azure.Cosmos.Table](https://nuget.org/packages/MassTransit.Azure.Cosmos.Table/)
* [MassTransit.DapperIntegration](https://nuget.org/packages/MassTransit.DapperIntegration/)
* [MassTransit.EntityFrameworkCore](https://nuget.org/packages/MassTransit.EntityFrameworkCore/)
* [MassTransit.MongoDb](https://nuget.org/packages/MassTransit.MongoDb/)
* [MassTransit.Redis](https://nuget.org/packages/MassTransit.Redis/)

### Message Data

* [MassTransit.Azure.Storage](https://nuget.org/packages/MassTransit.Azure.Storage/)

### Scheduling

* [MassTransit.Hangfire](https://nuget.org/packages/MassTransit.Hangfire/)
* [MassTransit.Quartz](https://nuget.org/packages/MassTransit.Quartz/)

### Interoperability

* [MassTransit.Interop.NServiceBus](https://nuget.org/packages/MassTransit.Interop.NServiceBus/)
* [MassTransit.MessagePack](https://nuget.org/packages/MassTransit.MessagePack/)
* [MassTransit.Newtonsoft](https://nuget.org/packages/MassTransit.Newtonsoft/)

### Other

* [MassTransit.SignalR](https://nuget.org/packages/MassTransit.SignalR/)
* [MassTransit.StateMachineVisualizer](https://nuget.org/packages/MassTransit.StateMachineVisualizer/)
* [MassTransit.TestFramework](https://nuget.org/packages/MassTransit.TestFramework/)

## GitHub Issues

> Please do not open an issue on GitHub, unless you have spotted an actual bug in MassTransit.

Use [GitHub Discussions](https://github.com/MassTransit/MassTransit/discussions) to ask questions, bring up ideas, or other general items. Issues are not the
place for questions, and will either be converted to a discussion or closed.
