using System;

namespace CodeChen.Utils
{
	public static class RandomHelper
	{
		/// <summary>
		/// 生成设置范围内的Double的随机数 
		/// https://docs.microsoft.com/zh-cn/dotnet/api/system.random?view=netframework-4.8#Floats
		/// eg:_random.NextDouble(1.5, 2.5)  
		/// </summary>
		/// <param name="random">Random</param>
		/// <param name="minDouble">生成随机数的最大值</param>
		/// <param name="maxDouble">生成随机数的最小值</param>
		/// <param name="digits">保留小数位</param>
		/// <returns>当Random等于NULL的时候返回0;</returns>
		public static double NextDouble(this Random random, double minDouble, double maxDouble, int digits = 2)
		{
			return Math.Round(random.NextDouble() * (maxDouble - minDouble) + minDouble, digits);
		}
	}
}
