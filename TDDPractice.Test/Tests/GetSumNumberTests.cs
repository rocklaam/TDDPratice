using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPratice.Exceptions;
using TDDPratice.Utilities;

namespace TDDPractice.Test.Tests
{
	[TestClass]
	public class GetSumNumberTests
	{
		[TestMethod]
		public void ValidDataTest()
		{
			var filePath = "TestFiles/ValidFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			double sum = OperationHelpers.GetSum(input, 1);
			Assert.IsTrue(sum == 28);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataEmptyTest()
		{
			var filePath = "TestFiles/EmptyFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 1);
		}

		[TestMethod]
		[ExpectedException(typeof(DataFormatException))]
		public void DataMemberHasMore8DigitsTest()
		{
			var filePath = "TestFiles/MoreThan8Digits.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 1);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataMemberNegativeTest()
		{
			var filePath = "TestFiles/NegativeNumber.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 1);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataMemberFloatTest()
		{
			var filePath = "TestFiles/FloatNumber.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 1);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataHasMore10ColumnsTest()
		{
			var filePath = "TestFiles/MoreThan10Columns.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 1);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void ResultOverSizeTest()
		{
			var filePath = "TestFiles/SumOver8Ditgits.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 4);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void OverDataSizeTest()
		{
			var filePath = "TestFiles/ValidFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			OperationHelpers.GetSum(input, 6);
		}
	}
}