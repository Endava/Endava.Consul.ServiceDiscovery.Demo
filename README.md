![](res/Title.jpg)
# Building API Gateway with load balancer and service discovery
When designing solutions based on the micro service architecture, we often encounter the requirement for quick and easy management of the entire system, the highest possible automation, without the necessary adjustment of individual components.

That is why I decided to prepare a tutorial that demonstrates how to establish a micro service architecture in the simplest possible way, which can be quickly and very easily scaled and adapted to client requirements.

I did not want to interfere with the code and settings of individual services, but to control the system only with the settings of containers in Docker.

The result is a simple micro service architecture that can be easily scaled with just a few code changes in container settings, everything else is provided by Ocelot as gateway/load balancer and Consul as service discovery.

We can do the redeployment of a single service without coordinating the deployment with other services which are automatically registered at service discovery and available through gateway. You can imagine how big a boost this is for every development team!

Sure, using a gateway service this becomes a single point of failure to our architecture, so we need to deploy at least two replicas of it to have high availability. But I will leave this problem for you to play with. :)

## Architecture
![](res/Architecture.jpg)

## Conclusion
Micro service systems are not easy to build and maintain. This tutorial showed how straightforward we can develop and deploy an application with micro services architecture.
HashiCorp [Consul](https://www.consul.io/) has first-class support for service discovery, health-check, key-value storage and multi-data centers. [Ocelot](https://github.com/ThreeMammals/Ocelot) successfuly comunicates with Consul service registry and retrives service registrations, load balancer loops through available services and sends requests. Using both Ocelot and Consul, makes the life of developers facing such challenges much easier. Do you agree?

- [Visual Studio](https://www.visualstudio.com/vs/community) 2019 16.9.4 or greater
- [.NET SDK 5.0](https://dotnet.microsoft.com/download/dotnet/5.0)
- [Docker](https://www.docker.com/resources/what-container)

## Tags & Technologies
- [.NET 5.0](https://github.com/dotnet/core/blob/main/release-notes/5.0/5.0.5/5.0.5.md)
- [Docker](https://www.docker.com/resources/what-container)  
- [ASP.NET Core 5.0](https://docs.microsoft.com/en-us/aspnet/core/release-notes/aspnetcore-5.0?view=aspnetcore-5.0)
- [Ocelot](https://github.com/ThreeMammals/Ocelot)  
- [Consul](https://www.consul.io/)

## Contributing
Please refer to [CONTRIBUTING.md](CONTRIBUTING.md).

## Trademarks
Consul® is the registered trademark of HashiCorp.
