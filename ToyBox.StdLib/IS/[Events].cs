using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBox.StdLib.IS
{
    public delegate void GrabEvHandler(object sender, GrabEvArgs e);

    public class GrabEvArgs : EventArgs
    {
        public IBuffer Buffer { get; set; }
        public long ID { get; set; }
        public bool IsTDI { get; set; }
        public long StackCount { get; set; }
        public long CountNow { get; set; }
        public long CountEnd { get; set; }
    }

    public delegate void InspectionEvHandler(object sender, InspectionEvArgs e);

    public class InspectionEvArgs : EventArgs
    {
        public InspectionEvArgs(List<St_Defect> defectInfoArray)
        {
            DefectInfoArray = defectInfoArray;
        }

        public List<St_Defect> DefectInfoArray { get; set; }
    }

    public delegate void AllocatedEventHandler(object sender, AllocateEventArgs e);

    public class AllocateEventArgs : EventArgs
    {
    }

    public delegate void DisposedEventHandler(object sender, DisposeEventArgs e);

    public class DisposeEventArgs : EventArgs
    {
    }

    public delegate void ExcutedEventHandler(object sender, ExcuteEventArgs e);

    public class ExcuteEventArgs : EventArgs
    {
    }

    public delegate void AbortedEventHandler(object sender, AborteEventArgs e);

    public class AborteEventArgs : EventArgs
    {
    }

    public delegate void FinishedEventHandler(object sender, FinishEventArgs e);

    public class FinishEventArgs : EventArgs { }

    public delegate void ScanEventHandler(object sender, ScanEventArgs e);

    public class ScanEventArgs
    {
        public IBuffer Buffer { get; set; }
    }

    public delegate void ImageROISelectEventHandler(object sender, ROISelectEventArgs e);

    public class ROISelectEventArgs : EventArgs
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public object Tag { get; set; }

        public System.Windows.Rect GetRect() => new System.Windows.Rect(X1, Y1, X2 - X1, Y2 - Y1);

        public ROISelectEventArgs(double x1, double y1, double x2, double y2, object tag = null)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            Tag = tag;
        }
    }
}