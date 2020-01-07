namespace CodeChen.Utils
{
	public static class DateTimeHelper
	{
		/// <summary>
		/// 秒数转为时分秒（00:00:10） 格式
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
