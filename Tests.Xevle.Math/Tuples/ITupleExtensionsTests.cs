using System;
using NUnit.Framework;
using Xevle.Math.Tuples;

namespace Tests.Xevle.Math
{
	[TestFixture()]
	/// <summary>
	/// Test class to test ITupleExtensions
	/// </summary>
	public static class ITupleExtensionsTests
	{
		static double delta = 0.0001;

		#region Converter methods
		[Test()]
		/// <summary>
		/// Test the conversation from ITuple to Tuple3dc
		/// </summary>
		public static void TestToTuple3dc()
		{
			// Prepare test
			Tuple3dc tuple3dc = new Tuple3dc(1.1, 2.2, 3.5);
			Tuple3ds tuple3ds = new Tuple3ds(1.1, 2.2, 3.5);

			Tuple3dc fromTuple3dc = tuple3dc.ToTuple3dc();
			Tuple3dc fromTuple3ds = tuple3ds.ToTuple3dc();

			// Execute test
			Assert.AreEqual(1.1, fromTuple3dc.x, delta);
			Assert.AreEqual(2.2, fromTuple3dc.y, delta);
			Assert.AreEqual(3.5, fromTuple3dc.z, delta);

			Assert.AreEqual(1.1, fromTuple3ds.x, delta);
			Assert.AreEqual(2.2, fromTuple3ds.y, delta);
			Assert.AreEqual(3.5, fromTuple3ds.z, delta);
		}

		[Test()]
		/// <summary>
		/// Test the conversation from ITuple to Tuple3ds
		/// </summary>
		public static void TestToTuple3ds()
		{
			// Prepare test
			Tuple3dc tuple3dc = new Tuple3dc(1.1, 2.2, 3.5);
			Tuple3ds tuple3ds = new Tuple3ds(1.1, 2.2, 3.5);

			Tuple3ds fromTuple3dc = tuple3dc.ToTuple3ds();
			Tuple3ds fromTuple3ds = tuple3ds.ToTuple3ds();

			// Execute test
			Assert.AreEqual(1.1, fromTuple3dc.x, delta);
			Assert.AreEqual(2.2, fromTuple3dc.y, delta);
			Assert.AreEqual(3.5, fromTuple3dc.z, delta);

			Assert.AreEqual(1.1, fromTuple3ds.x, delta);
			Assert.AreEqual(2.2, fromTuple3ds.y, delta);
			Assert.AreEqual(3.5, fromTuple3ds.z, delta);
		}
		#endregion
	}
}

