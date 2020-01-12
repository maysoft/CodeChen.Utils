using System;

namespace CodeChen.Utils
{
	public static class DateTimeHelper
	{
		private static readonly DateTime Start1970 = DateTime.Parse("1970-01-01 00:00:00");

		/// <summary>
		/// 获取该时间相对于1970-01-01 00:00:00的毫秒数时间戳
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		public static double GetTotalMilliseconds(this DateTime dt)
		{
			return (dt - Start1970).TotalMilliseconds;
		}

		/// <summary>
		/// 秒数 转为时分秒（00:00:10） 格式
		/// </summary>
		/// <param name="second"></param>
		/// <returns></returns>
		public static string FormatDuring(long second)
		{
			long days = second / (1000 * 60 * 60 * 24);
			long hours = (second % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60);
			long minutes = (second % (1000 * 60 * 60)) / (1000 * 60);
			long seconds = (second % (1000 * 60)) / 1000;
			return $"{hours.ToString().PadLeft(2, '0')}:{minutes.ToString().PadLeft(2, '0')}:{seconds.ToString().PadLeft(2, '0')}";
		}
	}
}
