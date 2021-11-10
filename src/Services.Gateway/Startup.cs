using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.Cache.CacheManager;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Provider.Polly;

namespace Endava.Services.Gateway
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddOcelot()
				.AddConsul()
				.AddCacheManager(x =>
				{
					x.WithDictionaryHandle();
				})
				.AddPolly();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseOcelot().Wait();
		}
	}
}
