//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: maid/connection.proto
// Note: requires additional types generated from: maid/controller.proto
namespace maid.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ConnectionProto")]
  public partial class ConnectionProto : global::ProtoBuf.IExtensible
  {
    public ConnectionProto() {}
    
    private long _id = default(long);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(long))]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _host = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"host", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string host
    {
      get { return _host; }
      set { _host = value; }
    }
    private int _port = default(int);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"port", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int port
    {
      get { return _port; }
      set { _port = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: maid/controller.proto
namespace maid.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ControllerProto")]
  public partial class ControllerProto : global::ProtoBuf.IExtensible
  {
    public ControllerProto() {}
    
    private string _method_name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"method_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string method_name
    {
      get { return _method_name; }
      set { _method_name = value; }
    }
    private ulong _transmit_id = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"transmit_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong transmit_id
    {
      get { return _transmit_id; }
      set { _transmit_id = value; }
    }
    private bool _stub = default(bool);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"stub", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool stub
    {
      get { return _stub; }
      set { _stub = value; }
    }
    private bool _is_canceled = default(bool);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"is_canceled", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool is_canceled
    {
      get { return _is_canceled; }
      set { _is_canceled = value; }
    }
    private bool _failed = default(bool);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"failed", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool failed
    {
      get { return _failed; }
      set { _failed = value; }
    }
    private string _error_text = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"error_text", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string error_text
    {
      get { return _error_text; }
      set { _error_text = value; }
    }
    private bool _notify = default(bool);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"notify", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool notify
    {
      get { return _notify; }
      set { _notify = value; }
    }
    private byte[] _message = null;
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"message", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] message
    {
      get { return _message; }
      set { _message = value; }
    }
    private string _full_service_name = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"full_service_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string full_service_name
    {
      get { return _full_service_name; }
      set { _full_service_name = value; }
    }
    private maid.proto.ConnectionProto _connection = null;
    [global::ProtoBuf.ProtoMember(1001, IsRequired = false, Name=@"connection", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public maid.proto.ConnectionProto connection
    {
      get { return _connection; }
      set { _connection = value; }
    }
    private maid.proto.SessionProto _session = null;
    [global::ProtoBuf.ProtoMember(1002, IsRequired = false, Name=@"session", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public maid.proto.SessionProto session
    {
      get { return _session; }
      set { _session = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: maid/middleware.proto
// Note: requires additional types generated from: maid/controller.proto
// Note: requires additional types generated from: maid/connection.proto
namespace maid.proto
{
    public interface IMiddleware
    {
      maid.proto.ConnectionProto Connected(maid.proto.ConnectionProto request);
    maid.proto.ConnectionProto Disconnected(maid.proto.ConnectionProto request);
    maid.proto.ControllerProto ProcessRequest(maid.proto.ControllerProto request);
    maid.proto.ControllerProto ProcessResponse(maid.proto.ControllerProto request);
    maid.proto.ControllerProto ProcessRequestStub(maid.proto.ControllerProto request);
    maid.proto.ControllerProto ProcessResponseStub(maid.proto.ControllerProto request);
    
    }
    
    
}
// Generated from: maid/options.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
namespace maid.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MaidServiceOptions")]
  public partial class MaidServiceOptions : global::ProtoBuf.IExtensible
  {
    public MaidServiceOptions() {}
    
    private bool _notify = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"notify", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool notify
    {
      get { return _notify; }
      set { _notify = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MaidMethodOptions")]
  public partial class MaidMethodOptions : global::ProtoBuf.IExtensible
  {
    public MaidMethodOptions() {}
    
    private bool _notify = default(bool);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"notify", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool notify
    {
      get { return _notify; }
      set { _notify = value; }
    }
    private long _time_out = (long)-1;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"time_out", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue((long)-1)]
    public long time_out
    {
      get { return _time_out; }
      set { _time_out = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
// Generated from: maid/session.proto
// Note: requires additional types generated from: maid/controller.proto
namespace maid.proto
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SessionProto")]
  public partial class SessionProto : global::ProtoBuf.IExtensible
  {
    public SessionProto() {}
    
    private string _id = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string id
    {
      get { return _id; }
      set { _id = value; }
    }
    private ulong _expired_time = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"expired_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong expired_time
    {
      get { return _expired_time; }
      set { _expired_time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}