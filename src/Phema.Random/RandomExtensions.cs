using System;

using Microsoft.Extensions.DependencyInjection;

namespace Phema.Random
{
	public static class RandomExtensions
	{
		public static IServiceCollection AddRandom(this IServiceCollection services, Action<RandomOptions> options = null)
		{
			return services.Configure(options ?? (o => { }))
				.AddRandom<Internal.Random>();
		}
	}
}
