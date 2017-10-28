// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  typedef int int32;

//  ===========================================================================
public class Int32  {
  public int InnerValue {get; set;} = default(int);

  public Int32() {}

  public Int32(int value)
  {
    InnerValue = value;
  }

  public static void Encode(IByteWriter stream, Int32  encodedInt32) {
  XdrEncoding.EncodeInt32(encodedInt32.InnerValue, stream);
  }
  public static Int32 Decode(IByteReader stream) {
    Int32 decodedInt32 = new Int32();
  decodedInt32.InnerValue = XdrEncoding.DecodeInt32(stream);
    return decodedInt32;
  }
}
}
