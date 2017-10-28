// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  typedef opaque uint256[32];

//  ===========================================================================
public class Uint256  {
  public byte[] InnerValue {get; set;} = default(byte[]);

  public Uint256() {}

  public Uint256(byte[] value)
  {
    InnerValue = value;
  }

  public static void Encode(IByteWriter stream, Uint256  encodedUint256) {
  int uint256size = encodedUint256.InnerValue.Length;
  XdrEncoding.WriteFixOpaque(stream, (uint)uint256size, encodedUint256.InnerValue);
  }
  public static Uint256 Decode(IByteReader stream) {
    Uint256 decodedUint256 = new Uint256();
  int uint256size = 32;
  decodedUint256.InnerValue = new byte[uint256size];
  XdrEncoding.ReadFixOpaque(stream, (uint)uint256size);
    return decodedUint256;
  }
}
}
