using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace Phema.Random.Tests
{
	public class RandomTests
	{
		[Fact]
		public void RandomGeneratesSameNext()
		{
			var rng = new System.Random(1);
			
			var random = new ServiceCollection()
				.AddRandom(options => options.Random = new System.Random(1))
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.Equal(rng.Next(), random.Next());
			Assert.Equal(rng.Next(), random.Next());
			Assert.Equal(rng.Next(), random.Next());
		}
		
		[Fact]
		public void RandomGeneratesNextInMaxRange()
		{
			var random = new ServiceCollection()
				.AddRandom()
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.InRange(random.Next(1000), int.MinValue, 1000);
		}
		
		[Fact]
		public void RandomGeneratesNextInRange()
		{
			var random = new ServiceCollection()
				.AddRandom()
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.Equal(1000, random.Next(1000, 1001));
		}
	}
}