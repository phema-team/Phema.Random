using System;

namespace Phema.Random
{
	public interface IRandom
	{
		int Next();
		int Next(int maxValue);
		int Next(int minValue, int maxValue);
		Span<byte> NextBytes(int count);
		double NextDouble();
	}
}