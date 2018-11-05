using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;

namespace HighCPUWebJobDotNet
{
    public class Functions
    {
        public static void CronJob([TimerTrigger("*/10 * * * * *")] TimerInfo timer)
        {
            Console.WriteLine("Cron job fired!");
            HighCPUJob();
        }

        static void HighCPUJob()
        {
            string s = "s";
            for (int i = 0; i < 100000; i++)
                s += i.ToString();
            Console.WriteLine(s);
        }
    }
}
