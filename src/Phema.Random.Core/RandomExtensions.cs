using Microsoft.Extensions.DependencyInjection;

namespace Phema.Random
{
	public static class RandomExtensions
	{
		public static IServiceCollection AddRandom<TRandom>(this IServiceCollection services)
			where TRandom : class, IRandom
		{
			return services.AddScoped<IRandom, TRandom>();
		}

		public static bool NextBool(this IRandom random)
		{
			return random.Next(2) == 0;
		}
	}
}