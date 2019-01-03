using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDPratice.Exceptions;
using TDDPratice.Utilities;

namespace TDDPractice.Test
{
	[TestClass]
	public class GetHighestNumberTest
	{
		[TestMethod]
		public void ValidDataTest()
		{
			var filePath = "TestFiles/ValidFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumber = OperationHelpers.GetHighestNumber(input, out int lineNumber);
			Assert.IsTrue(highestNumber == 345345 && lineNumber == 4);
		}

		[TestMethod]
		public void DataEmptyTest()
		{
			var filePath = "TestFiles/EmptyFile.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumber = OperationHelpers.GetHighestNumber(input, out int lineNumber);
			Assert.IsTrue(highestNumber == 0 && lineNumber == 0);
		}

		[TestMethod]
		[ExpectedException(typeof(DataFormatException))]
		public void DataMemberHasMore8DigitsTest()
		{
			var filePath = "TestFiles/MoreThan8Digits.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumber = OperationHelpers.GetHighestNumber(input, out int lineNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataMemberNegativeTest()
		{
			var filePath = "TestFiles/NegativeNumber.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumber = OperationHelpers.GetHighestNumber(input, out int lineNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataMemberFloatTest()
		{
			var filePath = "TestFiles/FloatNumber.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumber = OperationHelpers.GetHighestNumber(input, out int lineNumber);
		}

		[TestMethod]
		[ExpectedException(typeof(OperationException))]
		public void DataHasMore10ColumnsTest()
		{
			var filePath = "TestFiles/MoreThan10Columns.txt";
			var input = FileHelpers.ReadFile(filePath);
			long highestNumber = OperationHelpers.GetHighestNumber(input, out int lineNumber);
		}
	}
}
