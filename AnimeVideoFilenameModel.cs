using System;
using System.Collections.Generic;
using System.Text;

namespace Biyori.AnimeVFParser
{
    public class AnimeVideoFilenameModel
    {
        public string ReleaseGroup { get; set; }
        public int ReleaseVersion { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Episode { get; set; }
        public string EpisodeTitle { get; set; }
        public VideoResolution Resolution { get; set; }
        public string VideoTerm { get; set; }
        public string AudioTerm { get; set; }
        public string Checksum { get; set; }
        public struct VideoResolution
        {
            int Width;
            int Height;
            public override string ToString()
            {
                return $"{Width}x{Height}";
            }
        }
    }
}
