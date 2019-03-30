using System;
using System.Security.Cryptography;

namespace Phema.Random.Internal
{
	internal sealed class CryptoRandom : IRandom
	{
		public int Next()
		{
			Span<byte> span = stackalloc byte[4];

			RandomNumberGenerator.Fill(span);

			return BitConverter.ToInt32(span);
		}

		public int Next(int toExclusive)
		{
			return RandomNumberGenerator.GetInt32(toExclusive);
		}

		public int Next(int fromInclusive, int toExclusive)
		{
			return RandomNumberGenerator.GetInt32(fromInclusive, toExclusive);
		}

		public Span<byte> NextBytes(int count)
		{
			Span<byte> span = new byte[count];

			RandomNumberGenerator.Fill(span);

			return span;
		}

		public double NextDouble()
		{
			Span<byte> span = stackalloc byte[8];

			RandomNumberGenerator.Fill(span);

			return BitConverter.ToDouble(span);
		}
	}
}