namespace CodeChen.Utils
{
	public static class StringHelper
	{
		/// <summary>
		/// 字符串转int32 如果字符串为null或者空 返回自定义数值，默认返回0
		/// </summary>
		/// <param name="str"></param>
		/// <param name="defaultValue">如果字符串为null或者空 返回的默认值 不填默认为0</param>
		/// <returns></returns>
		public static int ToInt32(this string str, int defaultValue = 0)
		{
			if (string.IsNullOrWhiteSpace(str)) return defaultValue;
			return int.TryParse(str, out int returnValue) ? returnValue : defaultValue;
		}

		public static long ToInt64(this string str, long defaultValue = 0)
		{
			if (string.IsNullOrWhiteSpace(str)) return defaultValue;
			return long.TryParse(str, out long returnValue) ? returnValue : defaultValue;
		}
	}
}
