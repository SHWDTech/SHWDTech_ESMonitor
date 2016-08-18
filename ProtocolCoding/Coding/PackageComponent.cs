using EsMonitor.Model.ModelEnums;

namespace ProtocolCoding.Coding
{
    /// <summary>
    /// 协议包组件
    /// </summary>
    public class PackageComponent : IPackageComponent
    {
        public string ComponentName { get; set; }

        public string DataType { get; set; }

        public int ComponentIndex { get; set; }

        public byte[] ComponentBytes { get; set; }

        public DataValueType DataValueType { get; set; }

        public byte ValidFlag { get; set; }
    }
}
