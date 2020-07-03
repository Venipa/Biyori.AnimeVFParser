using System;

namespace Biyori.AnimeVFParser
{
    public class AnimeVideoFilenameParser
    {
        public string Filename { get; private set; }
        public AnimeVideoFilenameParser(string filename)
        {
            this.Filename = filename;
        }
        public void setFilename(string filename)
        {
            this.Filename = filename;
        }
        public AnimeVideoFilenameModel getInfo()
        {
            return new AnimeVideoFilenameModel()
            {
            };
        }
    }
}
