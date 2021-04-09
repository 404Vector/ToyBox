using OpenCvSharp.WpfExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static HYCK.Base.StdL.IS.MILConst;

namespace HYCK.Base.StdL.IS
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
        UNSIGNED1 = M_UNSIGNED + 0,
        UNSIGNED8 = M_UNSIGNED + 8,
        UNSIGNED16 = M_UNSIGNED + 16,
        UNSIGNED32 = M_UNSIGNED + 32,
        SIGNED1 = M_SIGNED + 0,
        SIGNED8 = M_SIGNED + 8,
        SIGNED16 = M_SIGNED + 16,
        SIGNED32 = M_SIGNED + 32,
        FLOAT = M_FLOAT,
        DOUBLE = -M_FLOAT,
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
        Bool = M_TYPE_BOOLEAN,
        Category = M_TYPE_CATEGORY,
        Command = M_TYPE_COMMAND,
        Double = M_TYPE_DOUBLE,
        Enumeration = M_TYPE_ENUMERATION,
        Long = M_TYPE_INT64,
        Register = M_TYPE_REGISTER,
        String = M_TYPE_STRING,
    }
}