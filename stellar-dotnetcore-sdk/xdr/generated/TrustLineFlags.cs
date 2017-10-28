// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  enum TrustLineFlags
//  {
//      // issuer has authorized account to perform transactions with its credit
//      AUTHORIZED_FLAG = 1
//  };

//  ===========================================================================
public class TrustLineFlags  {
  public enum TrustLineFlagsEnum {
  AUTHORIZED_FLAG = 1,
  }
  public TrustLineFlagsEnum InnerValue {get; set;} = default(TrustLineFlagsEnum);

  public static TrustLineFlags Create(TrustLineFlagsEnum v)
  {
    return new TrustLineFlags {
      InnerValue = v
    };
  }

  public static TrustLineFlags Decode(IByteReader stream) {
    int value = XdrEncoding.DecodeInt32(stream);
    switch (value) {
      case 1: return Create(TrustLineFlagsEnum.AUTHORIZED_FLAG);
      default:
        throw new Exception("Unknown enum value: " + value);
    }
  }

  public static void Encode(IByteWriter stream, TrustLineFlags value) {
    XdrEncoding.EncodeInt32((int)value.InnerValue, stream);
  }
}
}
