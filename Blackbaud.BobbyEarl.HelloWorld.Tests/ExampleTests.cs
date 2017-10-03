using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Blackbaud.BobbyEarl.HelloWorld.Tests
{
	[TestClass]
	public class ExampleTests
	{
		[TestMethod]
		public void TestMethod1()
		{
			var example = new Example();
			Assert.AreEqual("hey", example.SayHey());
		}
	}
}