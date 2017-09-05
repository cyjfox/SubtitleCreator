using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubtitleCreator
{

    class SubtitleFileFormat
    {
        public enum SubtitleFileFormatCode
        {
            FORMATCODE_SUB
        }

        private SubtitleFileFormatCode subtitleFileFormatCode;

        public SubtitleFileFormat()
        {
            Init(SubtitleFileFormatCode.FORMATCODE_SUB);
        }

        public SubtitleFileFormat(SubtitleFileFormatCode subtitleFileFormatCode)
        {
            Init(subtitleFileFormatCode);
        }

        private void Init(SubtitleFileFormatCode subtitleFileFormatCode)
        {
            this.subtitleFileFormatCode = subtitleFileFormatCode;
        }

        public static const SubtitleFileFormatCode FORMAT_SUB = SubtitleFileFormatCode.FORMATCODE_SUB;
    }
    
    /*
    public enum SubitleFileFormat
    {
        FORMAT_SUB
    }
    */
}
