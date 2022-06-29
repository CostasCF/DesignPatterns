using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Demo
{
    public class VideoRecAdapter : IVideoRecorder
    {
        private AdvancedVideoRecorder advancedVideoRecorder;

        public VideoRecAdapter()
        {
            advancedVideoRecorder = new AdvancedVideoRecorder(); 
        }
        public void record(string screenID, string quality)
        {
            advancedVideoRecorder.recordHighResolution(screenID,quality);
        }
    }
}
