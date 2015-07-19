using NUnit.Framework;
using System;
using Xevle.Math.Tuples;

namespace Tests.Xevle.Math
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void TestConstructor()
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
		public void TestUnaryOperatorPlus()
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
		public void TestUnaryOperatorMinus()
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
		public void TestUnaryOperatorMagnitude()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);
			double magnitude = !tuple;
			double diff = System.Math.Abs(3.74165738677394 - magnitude);          	

			// Execute test
			if (diff > 0.01)
			{
				Assert.Fail();
			}
		}

		[Test()]
		public void TestUnaryOperatorNormalize()
		{
			// Prepare test
			Tuple3dc tuple = new Tuple3dc(1, 2, 3);
			Tuple3dc normalizedTuple = ~tuple;

			double diffX = System.Math.Abs(0.267261241912424 - normalizedTuple.x);    
			double diffY = System.Math.Abs(0.534522483824849 - normalizedTuple.y);    
			double diffZ = System.Math.Abs(0.801783725737273 - normalizedTuple.z);    

			// Execute test
			if (diffX > 0.01) Assert.Fail();
			if (diffY > 0.01) Assert.Fail();
			if (diffZ > 0.01) Assert.Fail();
		}
		#endregion
		#endregion
	}
}

