using NUnit.Framework;
using System;
using Xevle.Math.Tuples;

namespace Tests.Xevle.Math
{
	[TestFixture()]
	public static class Test
	{
		static double delta=0.0001;
		
		[Test()]
		public static void TestConstructor()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);

			// Execute test
			Assert.AreEqual(1, tuple.x);
			Assert.AreEqual(2, tuple.y);
			Assert.AreEqual(3, tuple.z);
		}

		#region Test operators
		#region Unary operators
		[Test()]
		public static void TestUnaryOperatorPlus()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);
			tuple = +tuple;

			// Execute test
			Assert.AreEqual(1, tuple.x);
			Assert.AreEqual(2, tuple.y);
			Assert.AreEqual(3, tuple.z);
		}

		[Test()]
		public static void TestUnaryOperatorMinus()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);
			tuple = -tuple;

			// Execute test
			Assert.AreEqual(-1, tuple.x);
			Assert.AreEqual(-2, tuple.y);
			Assert.AreEqual(-3, tuple.z);
		}

		[Test()]
		public static void TestUnaryOperatorMagnitude()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);
			double magnitude = !tuple;

			// Execute test
			Assert.AreEqual(3.74165738677394, magnitude, delta);
		}

		[Test()]
		public static void TestUnaryOperatorNormalize()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);
			Tuple3dc normalizedTuple = ~tuple;

			// Execute test
			Assert.AreEqual(0.267261241912424, normalizedTuple.x, delta);
			Assert.AreEqual(0.534522483824849, normalizedTuple.y, delta);
			Assert.AreEqual(0.801783725737273, normalizedTuple.z, delta);
		}
		#endregion

		#region Binary operators
		[Test()]
		public static void TestAddition()
		{
			// Prepare test
			Tuple3dc a = new Tuple3dc(1, 2, 3);
			Tuple3dc b = new Tuple3dc(4, 5, 6);
			Tuple3dc c = a + b;

			// Execute test
			Assert.AreEqual(5, c.x, delta);
			Assert.AreEqual(7, c.y, delta);
			Assert.AreEqual(9, c.z, delta);
		}
		#endregion
		#endregion
	}
}

