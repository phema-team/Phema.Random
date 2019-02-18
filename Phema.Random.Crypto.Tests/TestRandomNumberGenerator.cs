using System.Security.Cryptography;

namespace Phema.Random.Crypto.Tests
{
	public sealed class TestRandomNumberGenerator : RandomNumberGenerator
	{
		private readonly byte[] bytes;

		public TestRandomNumberGenerator(byte[] bytes)
		{
			this.bytes = bytes;
		}
		
		public override void GetBytes(byte[] data)
		{
			bytes.CopyTo(data, 0);
		}
	}
}