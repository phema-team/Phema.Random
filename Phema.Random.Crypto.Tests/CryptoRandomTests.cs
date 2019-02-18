using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace Phema.Random.Crypto.Tests
{
	public class CryptoRandomTests
	{
		[Fact]
		public void RandomGeneratesSameNext()
		{
			var bytes = new byte[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 0};
			
			var random = new ServiceCollection()
				.AddPhemaCryptoRandom(options => options.Random = new TestRandomNumberGenerator(bytes))
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.Equal(bytes, random.NextBytes(10).ToArray());
		}
		
		[Fact]
		public void RandomGeneratesNextInMaxRange()
		{
			var random = new ServiceCollection()
				.AddPhemaCryptoRandom()
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.InRange(random.Next(1000), 0, 1000);
		}
		
		[Fact]
		public void RandomGeneratesNextInRange()
		{
			var random = new ServiceCollection()
				.AddPhemaCryptoRandom()
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.Equal(1000, random.Next(1000, 1001));
		}
	}
}