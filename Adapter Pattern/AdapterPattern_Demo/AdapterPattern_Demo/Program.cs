using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Demo
{
    public class Program
    {
        public static void Main()
        {
            VideoRecorder recorder = new VideoRecorder();

            recorder.record("1","1080p");
            recorder.record("2", "4k");
            Console.ReadLine();
        }
    }
}
