using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialChar
{
	public class ComFunc
	{

		public static T GetWetghtReturn<T>(double dWeight, T rtnItem1, T rtnItem2)
		{
			Random random = new Random(Guid.NewGuid().GetHashCode());
			double dWeightSum = dWeight + 1.0;
			double dValue = random.NextDouble() * dWeightSum;


			switch (dValue)
			{
				case double d when (0.0 <= d && d < 1.0):
					return rtnItem2;
				case double d when (1.0 <= d && d <= dWeightSum):
					return rtnItem1;
				default:
					//Unexpected	
					throw new Exception("Unexpected Error: T GetWetghtReturn<T>(int iWeightSum, T rtnItem1, T rtnItem2) ");
			}
		}
	}
}
