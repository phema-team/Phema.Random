using System;

using Microsoft.Extensions.DependencyInjection;

namespace Phema.Random
{
	public static class CryptoRandomExtensions
	{
		public static IServiceCollection AddPhemaCryptoRandom(this IServiceCollection services, Action<CryptoRandomOptions> options = null)
		{
			return services.Configure(options ?? (o => { }))
				.AddPhemaRandom<CryptoRandom>();
		}
	}
}
