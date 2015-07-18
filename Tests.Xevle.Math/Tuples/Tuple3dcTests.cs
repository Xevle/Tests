using NUnit.Framework;
using System;
using Xevle.Math.Tuples;

namespace Tests.Xevle.Math
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TestConstructor ()
		{
			Tuple3dc tuple = new Tuple3dc (1, 2, 3);
			Assert.AreEqual (1, tuple.x);
			Assert.AreEqual (2, tuple.y);
			Assert.AreEqual (3, tuple.z);
		}
	}
}

