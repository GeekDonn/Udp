using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace Udp
{
    public class Common
    {/// <summary>
     ///     利用CMD命令获取局域网内所有的IP
     /// </summary>
     /// <returns></returns>
        public static string GetAll()
        {
            var str = RunCmd("arp -a");
            var regex = new Regex(
                @"\s*(([0-9]{0,3}[.]?){4}\s)\s*(([a-zA-Z0-9]{2}[-]?){6}\s)\s*([\u4e00-\u9fa5]{0,4}\s)",
                RegexOptions.IgnoreCase);
            var match = regex.Matches(str);
            return match.Cast<object>().Aggregate("", (current, ma) => current + ma.ToString());
        }


        /// <summary>
        ///     执行CMD语句
        /// </summary>
        /// <param name="cmd">要执行的CMD命令</param>
        public static string RunCmd(string cmd)
        {
            var pro = new Process
            {
                StartInfo =
                {
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardError = true,
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true
                }
            };
            pro.Start();
            pro.StandardInput.WriteLine(cmd);
            pro.StandardInput.WriteLine("exit");
            var outStr = pro.StandardOutput.ReadToEnd();
            pro.Close();
            return outStr;
        }
    }
}
