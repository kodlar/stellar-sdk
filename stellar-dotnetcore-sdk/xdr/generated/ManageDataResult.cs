// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  union ManageDataResult switch (ManageDataResultCode code)
//  {
//  case MANAGE_DATA_SUCCESS:
//      void;
//  default:
//      void;
//  };

//  ===========================================================================
public class ManageDataResult  {
  public ManageDataResult () {}

  public ManageDataResultCode Discriminant { get; set; } = new ManageDataResultCode();

  public static void Encode(IByteWriter stream, ManageDataResult encodedManageDataResult) {
  XdrEncoding.EncodeInt32((int)encodedManageDataResult.Discriminant.InnerValue, stream);
  switch (encodedManageDataResult.Discriminant.InnerValue) {
  case ManageDataResultCode.ManageDataResultCodeEnum.MANAGE_DATA_SUCCESS:
  break;
  default:
  break;
  }
  }
  public static ManageDataResult Decode(IByteReader stream) {
  ManageDataResult decodedManageDataResult = new ManageDataResult();
  ManageDataResultCode discriminant = ManageDataResultCode.Decode(stream);
  decodedManageDataResult.Discriminant = discriminant;
  switch (decodedManageDataResult.Discriminant.InnerValue) {
  case ManageDataResultCode.ManageDataResultCodeEnum.MANAGE_DATA_SUCCESS:
  break;
  default:
  break;
  }
    return decodedManageDataResult;
  }
}
}
