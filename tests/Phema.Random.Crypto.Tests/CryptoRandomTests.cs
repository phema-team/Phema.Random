using Microsoft.Extensions.DependencyInjection;

using Xunit;

namespace Phema.Random.Crypto.Tests
{
	public class CryptoRandomTests
	{
		[Fact]
		public void RandomGeneratesNextInMaxRange()
		{
			var random = new ServiceCollection()
				.AddCryptoRandom()
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.InRange(random.Next(1000), 0, 1000);
		}
		
		[Fact]
		public void RandomGeneratesNextInRange()
		{
			var random = new ServiceCollection()
				.AddCryptoRandom()
				.BuildServiceProvider()
				.GetRequiredService<IRandom>();
			
			Assert.Equal(1000, random.Next(1000, 1001));
		}
	}
}