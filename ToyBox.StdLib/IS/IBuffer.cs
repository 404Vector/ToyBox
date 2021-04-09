using OpenCvSharp;
using System;
using System.Collections;
using System.Windows;

namespace HYCK.Base.StdL.IS
{
    public interface IBuffer : IISUnit, ICloneable
    {
        long Attriute { get; }
        ImageBandType BandType { get; }
        Array Data { get; }
        ImageDataType DataType { get; }
        int Depth { get; }
        long Height { get; }
        System.Windows.Size Size { get; }
        long Width { get; }

        public static MatType GetMatType(IBuffer buffer)
        {
            return buffer.DataType switch
            {
                ImageDataType.UNSIGNED8 => MatType.CV_8UC((int)buffer.BandType),
                ImageDataType.UNSIGNED16 => MatType.CV_16UC((int)buffer.BandType),
                ImageDataType.SIGNED8 => MatType.CV_8SC((int)buffer.BandType),
                ImageDataType.SIGNED16 => MatType.CV_16SC((int)buffer.BandType),
                ImageDataType.FLOAT => MatType.CV_32FC((int)buffer.BandType),
                _ => throw new FormatException("Unsupported BandType."),
            };
        }

        public static MatType GetMatType(ImageDataType dataType, ImageBandType bandType)
        {
            return dataType switch
            {
                ImageDataType.UNSIGNED8 => MatType.CV_8UC((int)bandType),
                ImageDataType.UNSIGNED16 => MatType.CV_16UC((int)bandType),
                ImageDataType.SIGNED8 => MatType.CV_8SC((int)bandType),
                ImageDataType.SIGNED16 => MatType.CV_16SC((int)bandType),
                ImageDataType.FLOAT => MatType.CV_32FC((int)bandType),
                _ => throw new FormatException("Unsupported BandType."),
            };
        }

        public MatType GetMatType()
        {
            IBuffer buffer = this;
            return buffer.DataType switch
            {
                ImageDataType.UNSIGNED8 => MatType.CV_8UC((int)buffer.BandType),
                ImageDataType.UNSIGNED16 => MatType.CV_16UC((int)buffer.BandType),
                ImageDataType.SIGNED8 => MatType.CV_8SC((int)buffer.BandType),
                ImageDataType.SIGNED16 => MatType.CV_16SC((int)buffer.BandType),
                ImageDataType.FLOAT => MatType.CV_32FC((int)buffer.BandType),
                _ => throw new FormatException("Unsupported BandType."),
            };
        }

        public Mat CreateMat() => new Mat((int)Height, (int)Width, GetMatType(), Data);
    }
}