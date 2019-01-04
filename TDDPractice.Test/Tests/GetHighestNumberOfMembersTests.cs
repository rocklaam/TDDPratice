using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPratice.Exceptions;
using TDDPratice.Utilities;

namespace TDDPractice.Test.Tests
{
	[TestClass]
	public class GetHighestNumberOfMembersOfMembersTests
	{
		[TestMethod]
		public void ValidDataTest()
		{
			var filePath = "TestFiles/ValidFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumberOfMembers = OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
			Assert.IsTrue(highestNumberOfMembers == 7);
			Assert.IsTrue(lineNumber == 5);
		}

		[TestMethod]
		public void DataEmptyTest()
		{
			var filePath = "TestFiles/EmptyFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumberOfMembers = OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
			Assert.IsTrue(highestNumberOfMembers == 0);
			Assert.IsTrue(lineNumber == 0);
		}

		[TestMethod]
		[ExpectedException(typeof(DataFormatException))]
		public void DataMemberHasMore8DigitsTest()
		{
			var filePath = "TestFiles/MoreThan8Digits.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataMemberNegativeTest()
		{
			var filePath = "TestFiles/NegativeNumber.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataMemberFloatTest()
		{
			var filePath = "TestFiles/FloatNumber.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataHasMore10ColumnsTest()
		{
			var filePath = "TestFiles/MoreThan10Columns.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
		}

		[TestMethod]
		public void DataHasMultipleResultTest()
		{
			var filePath = "TestFiles/MultipleResults.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumberOfMembers = OperationHelpers.GetHighestNumberOfMembers(input, out int lineNumber);
			Assert.IsTrue(highestNumberOfMembers == 7);
			Assert.IsTrue(lineNumber == 5);
		}
	}
}
