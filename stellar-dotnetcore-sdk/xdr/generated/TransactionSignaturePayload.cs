// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace stellar_dotnetcore_sdk.xdr {

// === xdr source ============================================================

//  struct TransactionSignaturePayload {
//      Hash networkId;
//      union switch (EnvelopeType type)
//      {
//      case ENVELOPE_TYPE_TX:
//            Transaction tx;
//      /* All other values of type are invalid */
//      } taggedTransaction;
//  };

//  ===========================================================================
public class TransactionSignaturePayload  {
  public TransactionSignaturePayload () {}
  public Hash NetworkId {get; set;}
  public TransactionSignaturePayloadTaggedTransaction TaggedTransaction {get; set;}

  public static void Encode(IByteWriter stream, TransactionSignaturePayload encodedTransactionSignaturePayload) {
    Hash.Encode(stream, encodedTransactionSignaturePayload.NetworkId);
    TransactionSignaturePayloadTaggedTransaction.Encode(stream, encodedTransactionSignaturePayload.TaggedTransaction);
  }
  public static TransactionSignaturePayload Decode(IByteReader stream) {
    TransactionSignaturePayload decodedTransactionSignaturePayload = new TransactionSignaturePayload();
    decodedTransactionSignaturePayload.NetworkId = Hash.Decode(stream);
    decodedTransactionSignaturePayload.TaggedTransaction = TransactionSignaturePayloadTaggedTransaction.Decode(stream);
    return decodedTransactionSignaturePayload;
  }

  public class TransactionSignaturePayloadTaggedTransaction {
    public TransactionSignaturePayloadTaggedTransaction () {}

    public EnvelopeType Discriminant { get; set; } = new EnvelopeType();

    public Transaction Tx {get; set;}
    public static void Encode(IByteWriter stream, TransactionSignaturePayloadTaggedTransaction encodedTransactionSignaturePayloadTaggedTransaction) {
    XdrEncoding.EncodeInt32((int)encodedTransactionSignaturePayloadTaggedTransaction.Discriminant.InnerValue, stream);
    switch (encodedTransactionSignaturePayloadTaggedTransaction.Discriminant.InnerValue) {
    case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX:
    Transaction.Encode(stream, encodedTransactionSignaturePayloadTaggedTransaction.Tx);
    break;
    }
    }
    public static TransactionSignaturePayloadTaggedTransaction Decode(IByteReader stream) {
    TransactionSignaturePayloadTaggedTransaction decodedTransactionSignaturePayloadTaggedTransaction = new TransactionSignaturePayloadTaggedTransaction();
    EnvelopeType discriminant = EnvelopeType.Decode(stream);
    decodedTransactionSignaturePayloadTaggedTransaction.Discriminant = discriminant;
    switch (decodedTransactionSignaturePayloadTaggedTransaction.Discriminant.InnerValue) {
    case EnvelopeType.EnvelopeTypeEnum.ENVELOPE_TYPE_TX:
    decodedTransactionSignaturePayloadTaggedTransaction.Tx = Transaction.Decode(stream);
    break;
    }
      return decodedTransactionSignaturePayloadTaggedTransaction;
    }

  }
}
}
