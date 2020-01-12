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
		public static int ToInt(this string str, int defaultValue = 0)
		{
			if (string.IsNullOrWhiteSpace(str)) return defaultValue;
			if (int.TryParse(str, out int returnValue)) return returnValue;
			else return defaultValue;
		}

	}
}
 