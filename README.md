MassTransit
===========

MassTransit is a _free, open-source_ distributed application framework for .NET. MassTransit makes it easy to create applications and services that leverage message-based, loosely-coupled asynchronous communication for higher availability, reliability, and scalability.

![Mass Transit](https://avatars2.githubusercontent.com/u/317796?s=200&v=4 "Mass Transit")

MassTransit is Apache 2.0 licensed.

## Fork Notice

This repository is a fork of [MassTransit/MassTransit](https://github.com/MassTransit/MassTransit).
Use upstream documentation for general usage guidance and API docs.

## Documentation

Get started by [reading through the documentation](https://masstransit-project.com/).

Build Status
------------

| Branch  |                                                                                              Status                                                                                              |
|---------|:------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------:|
| master  |  [![master](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml/badge.svg?branch=master&event=push)](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml)  |
| develop | [![develop](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml/badge.svg?branch=develop&event=push)](https://github.com/JacobChwastek/MassTransit/actions/workflows/build.yml) |

MassTransit NuGet Packages
---------------------------

| Package Name                                                    |   .NET   | .NET Standard |
|-----------------------------------------------------------------|:--------:|:-------------:|
| **Main**                                                        |          |               |
| [MassTransit][MassTransit.nuget]                                |   10.0   |               |
| [MassTransit.Abstractions][MassTransitAbstractions.nuget]       |   10.0   |               |
| [MassTransit.Newtonsoft][MassTransitNewtonsoft.nuget]           |   10.0   |               |
| [MassTransit.MessagePack][MassTransitMessagePack.nuget]         |   10.0   |               |
| **Other**                                                       |          |               |
| [MassTransit.SignalR][SignalR.nuget]                            |   10.0   |               |
| [MassTransit.Interop.NServiceBus][MassTransitNServiceBus.nuget] |   10.0   |               |
| [MassTransit.TestFramework][TestFramework.nuget]                |   10.0   |               |
| [MassTransit.StateMachineVisualizer][StateMachineVisualizer.nuget] | 10.0   |               |
| **Persistence**                                                 |          |               |
| [MassTransit.Azure.Cosmos][Cosmos.nuget]                        |   10.0   |               |
| [MassTransit.Azure.Storage][AzureStorage.nuget]                 |   10.0   |               |
| [MassTransit.Azure.Cosmos.Table][AzureTable.nuget]              |   10.0   |               |
| [MassTransit.DapperIntegration][Dapper.nuget]                   |   10.0   |               |
| [MassTransit.EntityFrameworkCore][EFCore.nuget]                 |   10.0   |               |
| [MassTransit.MongoDb][MongoDb.nuget]                            |   10.0   |               |
| [MassTransit.Redis][Redis.nuget]                                |   10.0   |               |
| **Scheduling**                                                  |          |               |
| [MassTransit.Hangfire][Hangfire.nuget]                          |   10.0   |               |
| [MassTransit.Quartz][Quartz.nuget]                              |   10.0   |               |
| **Transports**                                                  |          |               |
| [MassTransit.Azure.ServiceBus.Core][AzureSbCore.nuget]          |   10.0   |               |
| [MassTransit.RabbitMQ][RabbitMQ.nuget]                          |   10.0   |               |
| [MassTransit.SqlTransport.PostgreSQL][PostgreSQL.nuget]         |   10.0   |               |
| [MassTransit.SqlTransport.SqlServer][SqlServer.nuget]           |   10.0   |               |
| [MassTransit.WebJobs.EventHubs][EventHubs.nuget]                |   10.0   |               |
| [MassTransit.WebJobs.ServiceBus][AzureFunc.nuget]               |   10.0   |               |
| **Riders**                                                      |          |               |
| [MassTransit.Kafka][Kafka.nuget]                                |   10.0   |               |
| [MassTransit.EventHub][EventHub.nuget]                          |   10.0   |               |

### Fork Package Publishing

Fork CI publishes packages to GitHub Packages:

`https://nuget.pkg.github.com/<owner>/index.json`

For compatibility, current package IDs remain `MassTransit.*`.
If you plan to redistribute fork builds publicly, publish with fork-specific package IDs and metadata (for example `Jakub.MassTransit.*`) to avoid confusion with official upstream packages.

## Discord

Get help live at the MassTransit Discord server.

[![alt Join the conversation](https://img.shields.io/discord/682238261753675864.svg "Discord")](https://discord.gg/rNpQgYn)

## GitHub Issues

**Pay attention**

Please do not open an issue on GitHub, unless you have spotted an actual bug in MassTransit.

Use [GitHub Discussions](https://github.com/MassTransit/MassTransit/discussions) to ask questions, bring up ideas, or other general items. Issues are not the place for questions, and will either be converted to a discussion or closed.

This policy is in place to avoid bugs being drowned out in a pile of sensible suggestions for future
enhancements and calls for help from people who forget to check back if they get it and so on.

## Building from Source

 1. Install the latest [.NET 10 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/10.0)
 2. Clone the source down to your machine<br/>
    ```bash
    git clone https://github.com/JacobChwastek/MassTransit.git
    ```
 3. Run `dotnet build`

## Contributing

 1. Turn off `autocrlf`
    ```bash
    git config core.autocrlf false
    ```
 2. Hack!
 3. Make a pull request

# REQUIREMENTS
* .NET 10 SDK

# CREDITS
Logo Design by _The Agile Badger_

[MassTransit.nuget]: https://www.nuget.org/packages/MassTransit
[MassTransitAbstractions.nuget]: https://www.nuget.org/packages/MassTransit.Abstractions
[MassTransitNewtonsoft.nuget]: https://www.nuget.org/packages/MassTransit.Newtonsoft
[MassTransitMessagePack.nuget]: https://www.nuget.org/packages/MassTransit.MessagePack
[MassTransitNServiceBus.nuget]: https://www.nuget.org/packages/MassTransit.Interop.NServiceBus
[SignalR.nuget]: https://www.nuget.org/packages/MassTransit.SignalR
[TestFramework.nuget]: https://www.nuget.org/packages/MassTransit.TestFramework
[StateMachineVisualizer.nuget]: https://www.nuget.org/packages/MassTransit.StateMachineVisualizer

[Cosmos.nuget]: https://www.nuget.org/packages/MassTransit.Azure.Cosmos
[AzureStorage.nuget]: https://www.nuget.org/packages/MassTransit.Azure.Storage
[AzureTable.nuget]: https://www.nuget.org/packages/MassTransit.Azure.Cosmos.Table
[Dapper.nuget]: https://www.nuget.org/packages/MassTransit.DapperIntegration
[EFCore.nuget]: https://www.nuget.org/packages/MassTransit.EntityFrameworkCore
[MongoDb.nuget]: https://www.nuget.org/packages/MassTransit.MongoDb
[Redis.nuget]: https://www.nuget.org/packages/MassTransit.Redis

[Hangfire.nuget]: https://www.nuget.org/packages/MassTransit.Hangfire
[Quartz.nuget]: https://www.nuget.org/packages/MassTransit.Quartz

[AzureSbCore.nuget]: https://www.nuget.org/packages/MassTransit.Azure.ServiceBus.Core
[RabbitMQ.nuget]: https://www.nuget.org/packages/MassTransit.RabbitMQ
[PostgreSQL.nuget]: https://nuget.org/packages/MassTransit.SqlTransport.PostgreSQL/
[SqlServer.nuget]: https://nuget.org/packages/MassTransit.SqlTransport.SqlServer/
[EventHubs.nuget]: https://www.nuget.org/packages/MassTransit.WebJobs.EventHubs
[AzureFunc.nuget]: https://www.nuget.org/packages/MassTransit.WebJobs.ServiceBus

[Kafka.nuget]: https://www.nuget.org/packages/MassTransit.Kafka
[EventHub.nuget]: https://www.nuget.org/packages/MassTransit.EventHub
