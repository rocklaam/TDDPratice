using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPratice.Exceptions;
using TDDPratice.Utilities;

namespace TDDPractice.Test.Tests
{
	[TestClass]
	public class ReadFileTests
	{
		[TestMethod]
		public void DataHasEmptyLineTest()
		{
			var filePath = "TestFiles/1EmptyLine.txt";
			Assert.IsTrue(FileHelpers.ReadFile(filePath).Count != 0);
		}

		[TestMethod]
		public void FilePathValidTest()
		{
			var filePath = "TestFiles/ValidFile.txt";
			Assert.IsTrue(FileHelpers.ReadFile(filePath).Count != 0);
		}

		[TestMethod]
		[ExpectedException(typeof(FileExeption))]
		public void FilePathEmptyTest()
		{
			var filePath = "";
			FileHelpers.ReadFile(filePath);
		}

		[TestMethod]
		[ExpectedException(typeof(FileExeption))]
		public void FilePathNotExistTest()
		{
			var filePath = "TestFiles/UnExistFile.txt";
			FileHelpers.ReadFile(filePath);
		}

		[TestMethod]
		public void FilePathHasSpaceTest()
		{
			var filePath = "TestFiles/Space File.txt";
			Assert.IsTrue(FileHelpers.ReadFile(filePath).Count != 0);
		}
	}
}
