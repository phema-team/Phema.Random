using System;

using Microsoft.Extensions.DependencyInjection;

namespace Phema.Random
{
	public static class RandomExtensions
	{
		public static IServiceCollection AddPhemaRandom(this IServiceCollection services, Action<RandomOptions> options = null)
		{
			return services.Configure(options ?? (o => { }))
				.AddPhemaRandom<Random>();
		}
	}
}
