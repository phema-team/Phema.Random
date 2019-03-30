using System;

namespace Phema.Random
{
	public interface IRandom
	{
		int Next();
		int Next(int toExclusive);
		int Next(int fromInclusive, int toExclusive);
		Span<byte> NextBytes(int count);
		double NextDouble();
	}
}