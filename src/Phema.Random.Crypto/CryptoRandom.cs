using System;
using System.Security.Cryptography;

using Microsoft.Extensions.Options;

namespace Phema.Random
{
	internal sealed class CryptoRandom : IRandom
	{
		private readonly RandomNumberGenerator random;
		
		public CryptoRandom(IOptions<CryptoRandomOptions> options)
		{
			random = options.Value.Random ?? new RNGCryptoServiceProvider();
		}
		
		public int Next()
		{
			Span<byte> span = stackalloc byte[4];
			
			random.GetBytes(span);

			return BitConverter.ToInt32(span);
		}

		public int Next(int maxValue)
		{
			return Next() % maxValue;
		}

		public int Next(int minValue, int maxValue)
		{
			var next = Next(maxValue - minValue);
			
			return next + minValue;
		}

		public Span<byte> NextBytes(int count)
		{
			Span<byte> span = new byte[count];
			
			random.GetBytes(span);

			return span;
		}

		public double NextDouble()
		{
			Span<byte> span = stackalloc byte[8];
			
			random.GetBytes(span);

			return BitConverter.ToDouble(span);
		}
	}
}