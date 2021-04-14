using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToyBox.StdLib.IS
{
    public enum GCFCachingMode
    {
        NONE = MILConst.M_FEATURE_CACHING_MODE_NONE,
        WRITE_AROUND = MILConst.M_FEATURE_CACHING_MODE_WRITE_AROUND,
        WRITE_THROUGH = MILConst.M_FEATURE_CACHING_MODE_WRITE_THROUGH,
    }

    public enum GCFRepresentationType
    {
        BOOLEAN = MILConst.M_FEATURE_REPRESENTATION_BOOLEAN,
        HEX_NUMBER = MILConst.M_FEATURE_REPRESENTATION_HEX_NUMBER,
        IPV4_ADDRESS = MILConst.M_FEATURE_REPRESENTATION_IPV4_ADDRESS,
        LINEAR = MILConst.M_FEATURE_REPRESENTATION_LINEAR,
        LOGARITHMIC = MILConst.M_FEATURE_REPRESENTATION_LOGARITHMIC,
        MAC_ADDRESS = MILConst.M_FEATURE_REPRESENTATION_MAC_ADDRESS,
        PURE_NUMBER = MILConst.M_FEATURE_REPRESENTATION_PURE_NUMBER,
    }

    public enum GCFVisibilityType
    {
        Biginner = MILConst.M_FEATURE_VISIBILITY_BEGINNER,
        Expert = MILConst.M_FEATURE_VISIBILITY_EXPERT,
        Guru = MILConst.M_FEATURE_VISIBILITY_GURU,
        Invisible = MILConst.M_FEATURE_VISIBILITY_INVISIBLE,
    }

    public enum GCFUserVarType : long
    {
        BOOL = MILConst.M_TYPE_BOOLEAN,
        DOUBLE = MILConst.M_TYPE_DOUBLE,
        LONG = MILConst.M_TYPE_INT64,
        STRING = MILConst.M_TYPE_STRING,
    }

    public interface IGeniCamFeature
    {
        public bool IsAvailable { get; }

        public bool IsImplemented { get; }

        public bool IsReadable { get; }

        public bool IsWritable { get; }

        public GCFCachingMode CachingMode { get; }

        public bool IsDeprecated { get; }

        public string Description { get; }

        public string DisplayName { get; }

        public string Name { get; }

        public long PollingInterval { get; }

        public bool IsPresent { get; }

        //public GCFRepresentationType RepresentationType { get; }
        public long SelectorCount { get; }

        public List<string> SelectorCollection { get; }

        public int ByteSize { get; }

        public bool IsStreamable { get; }

        public string ToolTip { get; }

        public GCFType ValueType { get; }

        public object ValueContext { get; }

        public GCFVisibilityType VisibilityType { get; }

        public ObservableCollection<IGeniCamFeature> Children { get; }
    }
}