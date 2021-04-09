using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

using static HYCK.Base.StdL.IS.MILConst;

namespace HYCK.Base.StdL.IS
{
    public class BufferProperty
    {
        public long Attriute { get; set; } = M_IMAGE + M_GRAB + M_PROC + M_DISP;

        public ImageBandType BandType { get; set; } = ImageBandType.Null;

        public ImageDataType DataType { get; set; } = ImageDataType.Null;

        public int Depth { get; set; } = 0;

        public long Height { get; set; } = 0;

        public long Width { get; set; } = 0;

        public BufferProperty()
        {
        }

        public BufferProperty(long attriute, ImageBandType bandType, ImageDataType dataType, int depth, long height, long width)
        {
            Attriute = attriute;
            BandType = bandType;
            DataType = dataType;
            Depth = depth;
            Height = height;
            Width = width;
        }

        public BufferProperty(BufferProperty property)
        {
            Attriute = property.Attriute;
            BandType = property.BandType;
            DataType = property.DataType;
            Depth = property.Depth;
            Height = property.Height;
            Width = property.Width;
        }
    }
}