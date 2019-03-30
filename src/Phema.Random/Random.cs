using System;

using Microsoft.Extensions.Options;

namespace Phema.Random.Internal
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

		public int Next(int toExclusive)
		{
			return random.Next(toExclusive);
		}

		public int Next(int fromInclusive, int toExclusive)
		{
			return random.Next(fromInclusive, toExclusive);
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