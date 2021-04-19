using OpenCvSharp.WpfExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBox.StdLib.IS
{
    public enum ScanDirectionType
    {
        Null,
        Top,
        Bottom,
        Left,
        Right,
    }

    public enum ISUnitType
    {
        Null = -1,
        Core,
        Grabber,
        Buffer,
        System,
        BlobDetector,
        Display,
        Scan,
        Camera,
        Memory,
    }

    public enum ImageBandType
    {
        Null = -1,
        Mono = 1,
        Color = 3,
    }

    public enum ImageDataType
    {
        Null = -1,
        UNSIGNED1 = 0 + 0,
        UNSIGNED8 = 0 + 8,
        UNSIGNED16 = 0 + 16,
        UNSIGNED32 = 0 + 32,
        SIGNED1 = 128 + 0,
        SIGNED8 = 128 + 8,
        SIGNED16 = 128 + 16,
        SIGNED32 = 128 + 32,
        FLOAT = 256,
        DOUBLE = -256,
    }

    public enum CvImageDepthType
    {
        CV_8U = 0,
        CV_8S = 1,
        CV_16U = 2,
        CV_16S = 3,
        CV_32S = 4,
        CV_32F = 5,
        CV_64F = 6,
    }

    public enum SystemType
    {
        Null = -1,
        Virtual,
        MX_SYSTEM_DEFAULT,
        MX_SYSTEM_HOST,
        MX_SYSTEM_GIGE_VISION,
        MX_SYSTEM_USB3_VISION,
    }

    public enum PreDefinedIDType
    {
        CvSystem = -19940613,
        CvDigitizer,
        VirtualCVDigitizer,
        CVBuffer,
        SiSoSystem,
        SiSoDigitizer,
        SiSoMemoryHandler,
        SiSoBuffer,
    }

    public enum GCFType : long
    {
        Bool,
        Category,
        Command,
        Double,
        Enumeration,
        Long,
        Register,
        String,
    }
}