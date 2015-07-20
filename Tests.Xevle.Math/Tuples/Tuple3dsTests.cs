﻿using System;
using NUnit.Framework;
using Xevle.Math.Tuples;

namespace Tests.Xevle.Math
{
	[TestFixture()]
	public static class Tuple3dsTests
	{
		static double delta = 0.0001;

		[Test()]
		public static void TestConstructor()
		{
			// Prepare test
			Tuple3ds tuple = new Tuple3ds(1, 2, 3);

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
			Tuple3ds tuple = new Tuple3ds(1, 2, 3);
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
			Tuple3ds tuple = new Tuple3ds(1, 2, 3);
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
			Tuple3ds tuple = new Tuple3ds(1, 2, 3);
			double magnitude = !tuple;

			// Execute test
			Assert.AreEqual(3.74165738677394, magnitude, delta);
		}

		[Test()]
		public static void TestUnaryOperatorNormalize()
		{
			// Prepare test
			Tuple3ds tuple = new Tuple3ds(1, 2, 3);
			Tuple3ds normalizedTuple = ~tuple;

			// Execute test
			Assert.AreEqual(0.267261241912424, normalizedTuple.x, delta);
			Assert.AreEqual(0.534522483824849, normalizedTuple.y, delta);
			Assert.AreEqual(0.801783725737273, normalizedTuple.z, delta);
		}
		#endregion

		#region Binary operators
		[Test()]
		public static void TestBinaryOperatorPlus()
		{
			// Prepare test
			Tuple3ds a = new Tuple3ds(1, 2, 3);
			Tuple3ds b = new Tuple3ds(4, 5, 6);
			Tuple3ds c = a + b;

			// Execute test
			Assert.AreEqual(5, c.x, delta);
			Assert.AreEqual(7, c.y, delta);
			Assert.AreEqual(9, c.z, delta);
		}

		[Test()]
		public static void TestBinaryOperatorMinus()
		{
			// Prepare test
			Tuple3ds a = new Tuple3ds(1, 2, 3);
			Tuple3ds b = new Tuple3ds(4, 5, 6);
			Tuple3ds c = a - b;

			// Execute test
			Assert.AreEqual(-3, c.x, delta);
			Assert.AreEqual(-3, c.y, delta);
			Assert.AreEqual(-3, c.z, delta);
		}
		#endregion
		#endregion

		#region Methods
		[Test()]
		public static void TestAngleTo()
		{
			// Prepare test
			Tuple3ds a = new Tuple3ds(1, 2, 3);
			Tuple3ds b = new Tuple3ds(4, 5, 6);
			double angle = a.AngleTo(b);

			// Execute test
			Assert.AreEqual(0.225726128552734, angle, delta);
		}

		[Test()]
		public static void TestEpsilonEquals()
		{
			// Prepare test
			Tuple3ds a = new Tuple3ds(1, 2, 3);
			Tuple3ds b = new Tuple3ds(1.05, 2.05, 3.05);
			Tuple3ds c = new Tuple3ds(1, 2, 3.20);

			bool equalsAB = a.EpsilonEquals(b, 0.1);
			bool equalsAC = a.EpsilonEquals(c, 0.1);

			// Execute test
			Assert.AreEqual(true, equalsAB);
			Assert.AreEqual(false, equalsAC);

		}

		[Test()]
		public static void TestEpsilonEquals2D()
		{
			// Prepare test
			Tuple3ds a = new Tuple3ds(1, 2, 3);
			Tuple3ds b = new Tuple3ds(1.05, 2.05, 3.05);
			Tuple3ds c = new Tuple3ds(1, 2, 3.20);
			Tuple3ds d = new Tuple3ds(1, 2.20, 3.20);

			bool equalsAB = a.EpsilonEquals2D(b, 0.1);
			bool equalsAC = a.EpsilonEquals2D(c, 0.1);
			bool equalsAD = a.EpsilonEquals2D(d, 0.1);

			// Execute test
			Assert.AreEqual(true, equalsAB);
			Assert.AreEqual(true, equalsAC);
			Assert.AreEqual(false, equalsAD);
		}
		#endregion
	}
}
