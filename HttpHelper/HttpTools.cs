using System;
using System.Collections.Generic;
using System.Text;
using SufeiUtil;

namespace CodeChen.Utils
{
	/// <summary>
	/// 对HttpHelper简单封装
	/// </summary>
	public class HttpTools
	{
		public static HttpResult Get(string url)
		{
			return Request(url, "GET", "", "", "");
		}

		public static HttpResult PostForJson(string url, string postData)
		{
			return Request(url, "POST", postData, "", "");
		}

		public static HttpResult Request(string url, string method, string data, string accpet, string contentType)
		{
			HttpItem httpItem = new HttpItem
			{
				URL = url,
				Method = method,
				Accept = accpet,
				ContentType = contentType,
				Postdata = data,
			};
			HttpHelper httpHelper = new HttpHelper();
			return httpHelper.GetHtml(httpItem);
		}

	}
}
