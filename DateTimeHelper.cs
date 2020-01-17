using System;

namespace CodeChen.Utils
{
	public static class DateTimeHelper
	{
		private static readonly DateTime Start1970 = new DateTime(1970, 1, 1, 0, 0, 0);


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
		/// 将时间显示转换为更加友好的方式
		/// </summary>
		/// <param name="dt">要显示的时间</param>
		/// <returns>转换的结果</returns>
		public static string MakeDateTimeFriendly(this DateTime dt)
		{
			TimeSpan t = DateTime.Now - dt;

			if (t.TotalSeconds < 60) return string.Format("{0} 秒前", t.TotalSeconds > 0 ? (int)t.TotalSeconds : 0);
			if (t.TotalMinutes < 60) return string.Format("{0} 分钟前", (int)t.TotalMinutes);
			if (t.TotalHours < 24) return string.Format("{0} 小时前", (int)t.TotalHours);
			if (t.TotalDays < 2)
			{
				string prefix = string.Empty;
				switch ((int)(DateTime.Now.AddHours(-dt.Hour) - dt).TotalDays)
				{
					case 0: prefix = "昨天"; break;
					case 1: prefix = "前天"; break;
					default:
						break;
				}
				return string.Format("{0} {1}", prefix, dt.ToString("HH:mm:ss"));
			}
			return dt.ToString();
		}

		/// <summary>
		/// 将时间的天转换为友好的标记
		/// </summary>
		/// <param name="dt"></param>
		/// <returns></returns>
		public static string MakeDateFriendly(this DateTime dt)
		{
			var ts = dt.Date - DateTime.Now.Date;

			switch (ts.Days)
			{
				case 0:
					return "今天";
				case -1:
					return "昨天";
				case -2:
					return "前天";
				case 1:
					return "明天";
				case 2:
					return "后天";
			}

			return Math.Abs(ts.Days) + "天" + (ts.Days > 0 ? "后" : "前");
		}

		/// <summary>
		/// 获得Javascript中时间刻度
		/// </summary>
		/// <param name="dt">要表示的时间</param>
		/// <returns>类型为 <see cref="T:System.Int64"/> 格式的数值</returns>
		public static uint ToJsTicks(this DateTime dt)
		{
			return (uint)Math.Floor((dt.ToUniversalTime() - Start1970).Ticks / 10000.0);
		}

		/// <summary>
		/// 获得两个日期之间的月数
		/// </summary>
		/// <param name="beginDate"></param>
		/// <param name="endDate"></param>
		/// <returns></returns>
		public static double GetMonthesBetween(this DateTime beginDate, DateTime endDate)
		{
			var months = 0.0;
			for (; beginDate <= endDate; beginDate = beginDate.AddMonths(1))
			{
				months++;
			}
			months = months - (beginDate - endDate).TotalDays / DateTime.DaysInMonth(endDate.Year, endDate.Month);
			return months;
		}

		/// <summary>
		/// 返回时间所在月份的第一天
		/// </summary>
		/// <param name="dt">当前时间</param>
		/// <returns>代表当月第一天的 <see cref="T:System.DateTime"/></returns>
		public static DateTime GetMonthStart(this DateTime dt)
		{
			return dt.AddDays(-DateTime.Now.Day + 1);
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
