using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialChar
{
	public class ComFunc
	{

		public static T GetWetghtReturn<T>(int iWeight1, int iWeight2, T rtnItem1, T rtnItem2)
		{
			if (iWeight1 < 0)
			{
				throw new ArgumentOutOfRangeException("iWeight1");
			}

			if (iWeight2 < 0)
			{
				throw new ArgumentOutOfRangeException("iWeight2");
			}

			Random random = new Random(Guid.NewGuid().GetHashCode());
			int iWeightSum = iWeight1 + iWeight2;
			int iValue = random.Next(iWeightSum);


			switch (iValue)
			{
				case int i when (0 <= i && i < iWeight1):
					return rtnItem1;
				case int i when (iWeight1 <= i && i <= iWeightSum):
					return rtnItem2;
				default:
					//Unexpected	
					throw new Exception("Unexpected Error: T GetWetghtReturn<T>(int iWeightSum, T rtnItem1, T rtnItem2) ");
			}
		}

		public static T GetWetghtReturn<T>(int iWeight, T rtnItem1, T rtnItem2)
		{
			return GetWetghtReturn(iWeight, 100 - iWeight, rtnItem1, rtnItem2);
		}


	}
}
