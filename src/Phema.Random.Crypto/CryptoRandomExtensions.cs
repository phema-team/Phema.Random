using Microsoft.Extensions.DependencyInjection;
using Phema.Random.Internal;

namespace Phema.Random
{
	public static class CryptoRandomExtensions
	{
		public static IServiceCollection AddCryptoRandom(this IServiceCollection services)
		{
			return services.AddRandom<CryptoRandom>();
		}
	}
}
