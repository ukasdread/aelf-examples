// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: vote_contract.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Contract {

  /// <summary>Holder for reflection information generated from vote_contract.proto</summary>
  public static partial class VoteContractReflection {

    #region Descriptor
    /// <summary>File descriptor for vote_contract.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VoteContractReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChN2b3RlX2NvbnRyYWN0LnByb3RvEgR2b3RlGhJhZWxmX29wdGlvbnMucHJv",
            "dG8aDGNvbW1vbi5wcm90bxobZ29vZ2xlL3Byb3RvYnVmL2VtcHR5LnByb3Rv",
            "Gh5nb29nbGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8iKAoPSW5pdGlhbGl6",
            "ZUlucHV0EhUKDXByb3Bvc2FsTmFtZXMYASADKAkiUAoFVm90ZXISDgoGd2Vp",
            "Z2h0GAEgASgNEg0KBXZvdGVkGAIgASgIEhoKCGRlbGVnYXRlGAMgASgLMggu",
            "QWRkcmVzcxIMCgR2b3RlGAQgASgNIiwKCFByb3Bvc2FsEgwKBG5hbWUYASAB",
            "KAkSEgoKdm90ZV9jb3VudBgCIAEoDTKNAwoMVm90ZUNvbnRyYWN0Ej0KCklu",
            "aXRpYWxpemUSFS52b3RlLkluaXRpYWxpemVJbnB1dBoWLmdvb2dsZS5wcm90",
            "b2J1Zi5FbXB0eSIAEjUKD0dpdmVSaWdodFRvVm90ZRIILkFkZHJlc3MaFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkiABIuCghEZWxlZ2F0ZRIILkFkZHJlc3Ma",
            "Fi5nb29nbGUucHJvdG9idWYuRW1wdHkiABI+CgRWb3RlEhwuZ29vZ2xlLnBy",
            "b3RvYnVmLlVJbnQzMlZhbHVlGhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5IgAS",
            "QwoSR2V0V2lubmluZ1Byb3Bvc2FsEhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5",
            "Gg4udm90ZS5Qcm9wb3NhbCIFiIn3AQESOQoOR2V0Q2hhaW5wZXJzb24SFi5n",
            "b29nbGUucHJvdG9idWYuRW1wdHkaCC5BZGRyZXNzIgWIifcBARoXssz2ARJD",
            "b250cmFjdC5Wb3RlU3RhdGVCC6oCCENvbnRyYWN0YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Aelf.AelfOptionsReflection.Descriptor, global::AElf.Common.CommonReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Contract.InitializeInput), global::Contract.InitializeInput.Parser, new[]{ "ProposalNames" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Contract.Voter), global::Contract.Voter.Parser, new[]{ "Weight", "Voted", "Delegate", "Vote" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Contract.Proposal), global::Contract.Proposal.Parser, new[]{ "Name", "VoteCount" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class InitializeInput : pb::IMessage<InitializeInput> {
    private static readonly pb::MessageParser<InitializeInput> _parser = new pb::MessageParser<InitializeInput>(() => new InitializeInput());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<InitializeInput> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contract.VoteContractReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput(InitializeInput other) : this() {
      proposalNames_ = other.proposalNames_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public InitializeInput Clone() {
      return new InitializeInput(this);
    }

    /// <summary>Field number for the "proposalNames" field.</summary>
    public const int ProposalNamesFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _repeated_proposalNames_codec
        = pb::FieldCodec.ForString(10);
    private readonly pbc::RepeatedField<string> proposalNames_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ProposalNames {
      get { return proposalNames_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as InitializeInput);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(InitializeInput other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!proposalNames_.Equals(other.proposalNames_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= proposalNames_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      proposalNames_.WriteTo(output, _repeated_proposalNames_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += proposalNames_.CalculateSize(_repeated_proposalNames_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(InitializeInput other) {
      if (other == null) {
        return;
      }
      proposalNames_.Add(other.proposalNames_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            proposalNames_.AddEntriesFrom(input, _repeated_proposalNames_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class Voter : pb::IMessage<Voter> {
    private static readonly pb::MessageParser<Voter> _parser = new pb::MessageParser<Voter>(() => new Voter());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Voter> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contract.VoteContractReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Voter() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Voter(Voter other) : this() {
      weight_ = other.weight_;
      voted_ = other.voted_;
      Delegate = other.delegate_ != null ? other.Delegate.Clone() : null;
      vote_ = other.vote_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Voter Clone() {
      return new Voter(this);
    }

    /// <summary>Field number for the "weight" field.</summary>
    public const int WeightFieldNumber = 1;
    private uint weight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Weight {
      get { return weight_; }
      set {
        weight_ = value;
      }
    }

    /// <summary>Field number for the "voted" field.</summary>
    public const int VotedFieldNumber = 2;
    private bool voted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Voted {
      get { return voted_; }
      set {
        voted_ = value;
      }
    }

    /// <summary>Field number for the "delegate" field.</summary>
    public const int DelegateFieldNumber = 3;
    private global::AElf.Common.Address delegate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::AElf.Common.Address Delegate {
      get { return delegate_; }
      set {
        delegate_ = value;
      }
    }

    /// <summary>Field number for the "vote" field.</summary>
    public const int VoteFieldNumber = 4;
    private uint vote_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Vote {
      get { return vote_; }
      set {
        vote_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Voter);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Voter other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Weight != other.Weight) return false;
      if (Voted != other.Voted) return false;
      if (!object.Equals(Delegate, other.Delegate)) return false;
      if (Vote != other.Vote) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Weight != 0) hash ^= Weight.GetHashCode();
      if (Voted != false) hash ^= Voted.GetHashCode();
      if (delegate_ != null) hash ^= Delegate.GetHashCode();
      if (Vote != 0) hash ^= Vote.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Weight != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Weight);
      }
      if (Voted != false) {
        output.WriteRawTag(16);
        output.WriteBool(Voted);
      }
      if (delegate_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Delegate);
      }
      if (Vote != 0) {
        output.WriteRawTag(32);
        output.WriteUInt32(Vote);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Weight != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Weight);
      }
      if (Voted != false) {
        size += 1 + 1;
      }
      if (delegate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Delegate);
      }
      if (Vote != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Vote);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Voter other) {
      if (other == null) {
        return;
      }
      if (other.Weight != 0) {
        Weight = other.Weight;
      }
      if (other.Voted != false) {
        Voted = other.Voted;
      }
      if (other.delegate_ != null) {
        if (delegate_ == null) {
          delegate_ = new global::AElf.Common.Address();
        }
        Delegate.MergeFrom(other.Delegate);
      }
      if (other.Vote != 0) {
        Vote = other.Vote;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Weight = input.ReadUInt32();
            break;
          }
          case 16: {
            Voted = input.ReadBool();
            break;
          }
          case 26: {
            if (delegate_ == null) {
              delegate_ = new global::AElf.Common.Address();
            }
            input.ReadMessage(delegate_);
            break;
          }
          case 32: {
            Vote = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Proposal : pb::IMessage<Proposal> {
    private static readonly pb::MessageParser<Proposal> _parser = new pb::MessageParser<Proposal>(() => new Proposal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Proposal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Contract.VoteContractReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proposal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proposal(Proposal other) : this() {
      name_ = other.name_;
      voteCount_ = other.voteCount_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Proposal Clone() {
      return new Proposal(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vote_count" field.</summary>
    public const int VoteCountFieldNumber = 2;
    private uint voteCount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint VoteCount {
      get { return voteCount_; }
      set {
        voteCount_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Proposal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Proposal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (VoteCount != other.VoteCount) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (VoteCount != 0) hash ^= VoteCount.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (VoteCount != 0) {
        output.WriteRawTag(16);
        output.WriteUInt32(VoteCount);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (VoteCount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(VoteCount);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Proposal other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.VoteCount != 0) {
        VoteCount = other.VoteCount;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            VoteCount = input.ReadUInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
