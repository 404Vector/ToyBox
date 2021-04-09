using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using OpenCvSharp;

namespace HYCK.Base.StdL.IS
{
    public class St_Defect
    {
        public int SliceIndex { get; set; }
        public int ImageIndex { get; set; }
        public double DefectX { get; set; }
        public double DefectY { get; set; }
        public double DefectWidth { get; set; }
        public double DefectHeight { get; set; }
        public int ClassID { get; set; }
    }

    public class St_Defect_WSI : St_Defect
    {
    }

    public struct St_Color
    {
        public St_Color(int red = 0, int green = 0, int blue = 0)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
    }

    public struct St_AlignmentProperty
    {
        public byte[] TargetImageData { get; set; }
        public byte[] ReferenceImageData { get; set; }
        public Rect ReferenceImageRect { get; set; }
        public Rect2f WorldPositionRect { get; set; }
    }

    public struct St_AlignmentResultProperty
    {
        /// <summary>
        /// radian
        /// </summary>
        public double DeltaThetaOfImage { get; set; }

        /// <summary>
        /// micron
        /// </summary>
        public double DeltaXOfImage { get; set; }

        /// <summary>
        /// micron
        /// </summary>
        public double DeltaYOfImage { get; set; }
    }

    public struct St_MxControl
    {
        public St_MxControl(long commendType, double commendValue)
        {
            CommendType = commendType;
            CommendValue = commendValue;
        }

        public long CommendType { get; set; }
        public double CommendValue { get; set; }
    }

    public class St_Defect_WEI : St_Defect
    {
    }

    public class St_WESurfaceProperty : NotifyPropertyChanged
    {
        public long OffsetX { get; set; }
        public long OffsetY { get; set; }
        public long InspectionWidth { get; set; }
        public long InspectionHeight { get; set; }
        public double ThresholdValue { get; set; }
        public int MinDetectArea { get; set; }
        public int MinDetectHeight { get; set; }
    }

    public class St_WEProfileProperty : NotifyPropertyChanged
    {
        public double Sensitivity { get; set; } = 1;
        public double Shifting { get; set; } = 1;
        public double FineThreasholdValue { get; set; } = 30;
        public double CoarseThresholdValue { get; set; } = 55;
        public int MinDetectArea { get; set; } = 4;
        public int MinDetectWidth { get; set; } = 2;
        public int MinDetectHeight { get; set; } = 2;
        public bool IsEnableResultImageSave { get; set; } = false;
    }

    public class St_WSSBDProperty : NotifyPropertyChanged
    {
        public byte ThreasholdValue { get; set; } = 40;
        public int MinDetectWidth { get; set; } = 3;
        public int MinDetectHeight { get; set; } = 3;
    }

    public class St_WSTICProperty : NotifyPropertyChanged
    {
        public double ThreasholdValue { get; set; } = 240;
        public double DeltaThreashold { get; set; } = 20;
        public int MinDetectWidth { get; set; } = 3;
        public int MinDetectHeight { get; set; } = 3;
        public double MinDetectArea { get; set; } = 4;
        public long OpenValue { get; set; } = 5;
        public long ErodeValue { get; set; } = 2;
        public double PocessingRetio { get; set; } = 1.0;
        public bool IsEnablePadErase { get; set; } = true;
        public bool IsEnableResultImageSave { get; set; } = false;
        public bool IsEnableRawResultImageSave { get; set; } = false;
    }
}