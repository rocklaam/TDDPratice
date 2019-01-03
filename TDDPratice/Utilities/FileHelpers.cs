using System;
using System.Collections.Generic;
using TDDPratice.Exceptions;

namespace TDDPratice.Utilities
{
	public class FileHelpers
	{
		public static List<List<long>> ReadFile(string filePath)
		{
			if (string.IsNullOrEmpty(filePath))
			{
				throw new FileExeption();
			}

			throw new NotImplementedException();
		}
	}
}
