using System;

using Microsoft.Extensions.Options;

namespace Phema.Random
{
	internal sealed class Random : IRandom
	{
		private readonly System.Random random;
		
		public Random(IOptions<RandomOptions> options)
		{
			random = options.Value.Random ?? new System.Random();
		}
		
		public int Next()
		{
			return random.Next();
		}

		public int Next(int maxValue)
		{
			return random.Next(maxValue);
		}

		public int Next(int minValue, int maxValue)
		{
			return random.Next(minValue, maxValue);
		}

		public Span<byte> NextBytes(int count)
		{
			Span<byte> span = new byte[count];
			
			random.NextBytes(span);

			return span;
		}

		public double NextDouble()
		{
			return random.NextDouble();
		}
	}
}