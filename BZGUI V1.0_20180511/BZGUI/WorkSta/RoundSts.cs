
using System;
using System.Text;


namespace BAM
{
	sealed class RoundSts
	{
		
        private const int loopTimes = 10000;

        static void Main(string[] args)
            {

            string str = string.Empty;

            string str1 = string.Empty;

            StringBuilder sb = new StringBuilder();

            DateTime timeStart = DateTime.Now;

            for (int i = 0; i < loopTimes; i++)
                {

                str += i.ToString();

                str += i.ToString();

                str += i.ToString();

                }

            Console.WriteLine(string.Format("字符串直接做加法运行{0}次的时间是:{1}", loopTimes, DateTime.Now.Subtract(timeStart)));

            timeStart = DateTime.Now;

            for (int i = 0; i < loopTimes; i++)
                {

                str1 += string.Format("{0}{1}{2}", i, i, i);

                }

            Console.WriteLine(string.Format("字符串format运行{0}次的时间是:{1}", loopTimes, DateTime.Now.Subtract(timeStart)));

            timeStart = DateTime.Now;

            for (int i = 0; i < loopTimes; i++)
                {

                sb.Append(i);

                sb.Append(i);

                sb.Append(i);

                }

            Console.WriteLine(string.Format("stringbuilder运行{0}次的时间是:{1}", loopTimes, DateTime.Now.Subtract(timeStart)));

            } 
		

		
	}
	
}
