using System.Diagnostics;

namespace CodeChen.Utils
{
	public class CmdHelper
	{
		/// <summary>
		/// 执行CMD命令
		/// </summary>
		/// <param name="command"></param>
		/// <returns></returns>
		public static string RunCmd(string command)
		{
			Process p = new Process();//创建进程对象
			ProcessStartInfo startInfo = new ProcessStartInfo();
			startInfo.FileName = "cmd.exe";//设定需要执行的命令
			startInfo.Arguments = "/C " + command;//“/C”表示执行完命令后马上退出
			startInfo.CreateNoWindow = true;//不创建窗口 
			startInfo.UseShellExecute = false;//不使用系统外壳程序启动
			startInfo.RedirectStandardError = false;
			startInfo.RedirectStandardInput = true;//重定向输入
			startInfo.RedirectStandardOutput = true; //重定向输出
			p.StartInfo = startInfo;
			p.Start();
			string output = p.StandardOutput.ReadToEnd();//获取cmd窗口的输出信息 
			p.WaitForExit();//等待程序执行完退出进程   
							//string output2 = p.StandardOutput.ReadToEnd();//获取cmd窗口的输出信息 
			p.Close();//结束  
			return output;
		} 
	}
}
