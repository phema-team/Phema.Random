using System;

namespace Phema.Random
{
	public sealed class RandomOptions
	{
		public RandomOptions()
		{
			RandomProvider = () => new System.Random();
		}

		public Func<System.Random> RandomProvider { get; set; }
	}
}