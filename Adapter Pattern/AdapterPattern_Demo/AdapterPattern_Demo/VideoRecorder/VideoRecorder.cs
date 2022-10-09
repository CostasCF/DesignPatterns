using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern_Demo
{
    public class VideoRecorder : IVideoRecorder
    {
        private VideoRecAdapter videoRecAdapter;

        public void record(string screenID, string quality)
        {
            if (quality.Equals("1080p"))
            {
                Console.WriteLine($"Recording at 1080p on screen id {screenID}");
            }
            else if (quality.Equals("4k"))
            {
                videoRecAdapter = new VideoRecAdapter();
                videoRecAdapter.record(screenID, quality);
            }
            else {
                Console.WriteLine("Select 1080p or 4k quality in order to start recording");
                    }
        }
    }
}
