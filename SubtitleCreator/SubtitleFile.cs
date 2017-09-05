using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SubtitleCreator
{
    class SubtitleFile
    {
        //字幕行列表
        List<SubtitleLine> subtileLines;
        //字幕行总数
        Int32 subtitleLineCount;
        SubitleFileFormat subtitleFileFormat;
        //字幕类型名称
        string typeName;
        //字幕文件全路径
        string filePath;
        //字幕文件名称
        string fileName;

    }
}
