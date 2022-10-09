using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Demo
{
    public class AdvancedVideoRecorder : IAdvancedVideoRecorder
    {
        public void recordHighResolution(string screenID, string quality)
        {
            Console.WriteLine($"Recording at 4k on screen id {screenID}");
        }
    }
}
