using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_Delegates_LamdaExpression_Using_C_
{
    delegate void logDel(string text);
    public class Delegate_Demo
    {
        static void Main2(string[] args)
        {
            LogData logData = new LogData();
            logDel delToScreen, delToFile;
            delToScreen = new logDel(logData.LogDataToScreen);
            delToFile=new logDel(logData.LogDataToFile);
            logDel multicastDel = delToScreen + delToFile;
            Console.WriteLine("Enter your name:");
            var name=Console.ReadLine();
            multicastDel(name);
            Console.ReadKey();



        }
    }

    public class LogData
    {
        public void LogDataToScreen(string text)
        {
            Console.WriteLine($"{DateTime.Now}:{text}");
        }

        public void LogDataToFile(string text)
        {
            using (StreamWriter streamWriter = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.Txt"), true))
            {
                streamWriter.WriteLine($"{DateTime.Now}:{text}");
            }
        }
    }

}
