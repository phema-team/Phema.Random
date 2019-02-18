using Microsoft.Extensions.DependencyInjection;

namespace Phema.Random
{
	public static class RandomExtensions
	{
		public static IServiceCollection AddPhemaRandom<TRandom>(this IServiceCollection services)
			where TRandom : class, IRandom
		{
			return services.AddScoped<IRandom, TRandom>();
		}
	}
}