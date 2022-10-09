using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Demo
{
    public interface IAdvancedVideoRecorder
    {
        void recordHighResolution(string screenID, string quality);
    }
}
