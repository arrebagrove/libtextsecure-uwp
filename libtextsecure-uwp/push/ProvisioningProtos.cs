// Generated by ProtoGen, Version=2.4.1.555, Culture=neutral, PublicKeyToken=55f7125234beb589.  DO NOT EDIT!
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace libtextsecure.push {
  
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ProvisioningProtos {
  
    #region Extension registration
    public static void RegisterAllExtensions(pb::ExtensionRegistry registry) {
    }
    #endregion
    #region Static variables
    private static pbd::MessageDescriptor internal__static_textsecure_ProvisionEnvelope__Descriptor;
    private static pb::FieldAccess.FieldAccessorTable<global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope, global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope.Builder> internal__static_textsecure_ProvisionEnvelope__FieldAccessorTable;
    private static pbd::MessageDescriptor internal__static_textsecure_ProvisionMessage__Descriptor;
    private static pb::FieldAccess.FieldAccessorTable<global::libtextsecure.push.ProvisioningProtos.ProvisionMessage, global::libtextsecure.push.ProvisioningProtos.ProvisionMessage.Builder> internal__static_textsecure_ProvisionMessage__FieldAccessorTable;
    #endregion
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbd::FileDescriptor descriptor;
    
    static ProvisioningProtos() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm92aXNpb25pbmcucHJvdG8SCnRleHRzZWN1cmUiNAoRUHJvdmlzaW9u", 
            "RW52ZWxvcGUSEQoJcHVibGljS2V5GAEgASgMEgwKBGJvZHkYAiABKAwicwoQ", 
            "UHJvdmlzaW9uTWVzc2FnZRIZChFpZGVudGl0eUtleVB1YmxpYxgBIAEoDBIa", 
            "ChJpZGVudGl0eUtleVByaXZhdGUYAiABKAwSDgoGbnVtYmVyGAMgASgJEhgK", 
            "EHByb3Zpc2lvbmluZ0NvZGUYBCABKAlCQQorb3JnLndoaXNwZXJzeXN0ZW1z", 
          "LnRleHRzZWN1cmUuaW50ZXJuYWwucHVzaEISUHJvdmlzaW9uaW5nUHJvdG9z"));
      pbd::FileDescriptor.InternalDescriptorAssigner assigner = delegate(pbd::FileDescriptor root) {
        descriptor = root;
        internal__static_textsecure_ProvisionEnvelope__Descriptor = Descriptor.MessageTypes[0];
        internal__static_textsecure_ProvisionEnvelope__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope, global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope.Builder>(internal__static_textsecure_ProvisionEnvelope__Descriptor,
                new string[] { "PublicKey", "Body", });
        internal__static_textsecure_ProvisionMessage__Descriptor = Descriptor.MessageTypes[1];
        internal__static_textsecure_ProvisionMessage__FieldAccessorTable = 
            new pb::FieldAccess.FieldAccessorTable<global::libtextsecure.push.ProvisioningProtos.ProvisionMessage, global::libtextsecure.push.ProvisioningProtos.ProvisionMessage.Builder>(internal__static_textsecure_ProvisionMessage__Descriptor,
                new string[] { "IdentityKeyPublic", "IdentityKeyPrivate", "Number", "ProvisioningCode", });
        return null;
      };
      pbd::FileDescriptor.InternalBuildGeneratedFileFrom(descriptorData,
          new pbd::FileDescriptor[] {
          }, assigner);
    }
    #endregion
    
    #region Messages
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ProvisionEnvelope : pb::GeneratedMessage<ProvisionEnvelope, ProvisionEnvelope.Builder> {
      private ProvisionEnvelope() { }
      private static readonly ProvisionEnvelope defaultInstance = new ProvisionEnvelope().MakeReadOnly();
      private static readonly string[] _provisionEnvelopeFieldNames = new string[] { "body", "publicKey" };
      private static readonly uint[] _provisionEnvelopeFieldTags = new uint[] { 18, 10 };
      public static ProvisionEnvelope DefaultInstance {
        get { return defaultInstance; }
      }
      
      public override ProvisionEnvelope DefaultInstanceForType {
        get { return DefaultInstance; }
      }
      
      protected override ProvisionEnvelope ThisMessage {
        get { return this; }
      }
      
      public static pbd::MessageDescriptor Descriptor {
        get { return global::libtextsecure.push.ProvisioningProtos.internal__static_textsecure_ProvisionEnvelope__Descriptor; }
      }
      
      protected override pb::FieldAccess.FieldAccessorTable<ProvisionEnvelope, ProvisionEnvelope.Builder> InternalFieldAccessors {
        get { return global::libtextsecure.push.ProvisioningProtos.internal__static_textsecure_ProvisionEnvelope__FieldAccessorTable; }
      }
      
      public const int PublicKeyFieldNumber = 1;
      private bool hasPublicKey;
      private pb::ByteString publicKey_ = pb::ByteString.Empty;
      public bool HasPublicKey {
        get { return hasPublicKey; }
      }
      public pb::ByteString PublicKey {
        get { return publicKey_; }
      }
      
      public const int BodyFieldNumber = 2;
      private bool hasBody;
      private pb::ByteString body_ = pb::ByteString.Empty;
      public bool HasBody {
        get { return hasBody; }
      }
      public pb::ByteString Body {
        get { return body_; }
      }
      
      public override bool IsInitialized {
        get {
          return true;
        }
      }
      
      public override void WriteTo(pb::ICodedOutputStream output) {
        CalcSerializedSize();
        string[] field_names = _provisionEnvelopeFieldNames;
        if (hasPublicKey) {
          output.WriteBytes(1, field_names[1], PublicKey);
        }
        if (hasBody) {
          output.WriteBytes(2, field_names[0], Body);
        }
        UnknownFields.WriteTo(output);
      }
      
      private int memoizedSerializedSize = -1;
      public override int SerializedSize {
        get {
          int size = memoizedSerializedSize;
          if (size != -1) return size;
          return CalcSerializedSize();
        }
      }
      
      private int CalcSerializedSize() {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasPublicKey) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, PublicKey);
        }
        if (hasBody) {
          size += pb::CodedOutputStream.ComputeBytesSize(2, Body);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
      public static ProvisionEnvelope ParseFrom(pb::ByteString data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(byte[] data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(global::System.IO.Stream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      public static ProvisionEnvelope ParseDelimitedFrom(global::System.IO.Stream input) {
        return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
      }
      public static ProvisionEnvelope ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(pb::ICodedInputStream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static ProvisionEnvelope ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      private ProvisionEnvelope MakeReadOnly() {
        return this;
      }
      
      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }
      public static Builder CreateBuilder(ProvisionEnvelope prototype) {
        return new Builder(prototype);
      }
      
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Builder : pb::GeneratedBuilder<ProvisionEnvelope, Builder> {
        protected override Builder ThisBuilder {
          get { return this; }
        }
        public Builder() {
          result = DefaultInstance;
          resultIsReadOnly = true;
        }
        internal Builder(ProvisionEnvelope cloneFrom) {
          result = cloneFrom;
          resultIsReadOnly = true;
        }
        
        private bool resultIsReadOnly;
        private ProvisionEnvelope result;
        
        private ProvisionEnvelope PrepareBuilder() {
          if (resultIsReadOnly) {
            ProvisionEnvelope original = result;
            result = new ProvisionEnvelope();
            resultIsReadOnly = false;
            MergeFrom(original);
          }
          return result;
        }
        
        public override bool IsInitialized {
          get { return result.IsInitialized; }
        }
        
        protected override ProvisionEnvelope MessageBeingBuilt {
          get { return PrepareBuilder(); }
        }
        
        public override Builder Clear() {
          result = DefaultInstance;
          resultIsReadOnly = true;
          return this;
        }
        
        public override Builder Clone() {
          if (resultIsReadOnly) {
            return new Builder(result);
          } else {
            return new Builder().MergeFrom(result);
          }
        }
        
        public override pbd::MessageDescriptor DescriptorForType {
          get { return global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope.Descriptor; }
        }
        
        public override ProvisionEnvelope DefaultInstanceForType {
          get { return global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope.DefaultInstance; }
        }
        
        public override ProvisionEnvelope BuildPartial() {
          if (resultIsReadOnly) {
            return result;
          }
          resultIsReadOnly = true;
          return result.MakeReadOnly();
        }
        
        public override Builder MergeFrom(pb::IMessage other) {
          if (other is ProvisionEnvelope) {
            return MergeFrom((ProvisionEnvelope) other);
          } else {
            base.MergeFrom(other);
            return this;
          }
        }
        
        public override Builder MergeFrom(ProvisionEnvelope other) {
          if (other == global::libtextsecure.push.ProvisioningProtos.ProvisionEnvelope.DefaultInstance) return this;
          PrepareBuilder();
          if (other.HasPublicKey) {
            PublicKey = other.PublicKey;
          }
          if (other.HasBody) {
            Body = other.Body;
          }
          this.MergeUnknownFields(other.UnknownFields);
          return this;
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input) {
          return MergeFrom(input, pb::ExtensionRegistry.Empty);
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          PrepareBuilder();
          pb::UnknownFieldSet.Builder unknownFields = null;
          uint tag;
          string field_name;
          while (input.ReadTag(out tag, out field_name)) {
            if(tag == 0 && field_name != null) {
              int field_ordinal = global::System.Array.BinarySearch(_provisionEnvelopeFieldNames, field_name, global::System.StringComparer.Ordinal);
              if(field_ordinal >= 0)
                tag = _provisionEnvelopeFieldTags[field_ordinal];
              else {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                continue;
              }
            }
            switch (tag) {
              case 0: {
                throw pb::InvalidProtocolBufferException.InvalidTag();
              }
              default: {
                if (pb::WireFormat.IsEndGroupTag(tag)) {
                  if (unknownFields != null) {
                    this.UnknownFields = unknownFields.Build();
                  }
                  return this;
                }
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                break;
              }
              case 10: {
                result.hasPublicKey = input.ReadBytes(ref result.publicKey_);
                break;
              }
              case 18: {
                result.hasBody = input.ReadBytes(ref result.body_);
                break;
              }
            }
          }
          
          if (unknownFields != null) {
            this.UnknownFields = unknownFields.Build();
          }
          return this;
        }
        
        
        public bool HasPublicKey {
          get { return result.hasPublicKey; }
        }
        public pb::ByteString PublicKey {
          get { return result.PublicKey; }
          set { SetPublicKey(value); }
        }
        public Builder SetPublicKey(pb::ByteString value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasPublicKey = true;
          result.publicKey_ = value;
          return this;
        }
        public Builder ClearPublicKey() {
          PrepareBuilder();
          result.hasPublicKey = false;
          result.publicKey_ = pb::ByteString.Empty;
          return this;
        }
        
        public bool HasBody {
          get { return result.hasBody; }
        }
        public pb::ByteString Body {
          get { return result.Body; }
          set { SetBody(value); }
        }
        public Builder SetBody(pb::ByteString value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasBody = true;
          result.body_ = value;
          return this;
        }
        public Builder ClearBody() {
          PrepareBuilder();
          result.hasBody = false;
          result.body_ = pb::ByteString.Empty;
          return this;
        }
      }
      static ProvisionEnvelope() {
        object.ReferenceEquals(global::libtextsecure.push.ProvisioningProtos.Descriptor, null);
      }
    }
    
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public sealed partial class ProvisionMessage : pb::GeneratedMessage<ProvisionMessage, ProvisionMessage.Builder> {
      private ProvisionMessage() { }
      private static readonly ProvisionMessage defaultInstance = new ProvisionMessage().MakeReadOnly();
      private static readonly string[] _provisionMessageFieldNames = new string[] { "identityKeyPrivate", "identityKeyPublic", "number", "provisioningCode" };
      private static readonly uint[] _provisionMessageFieldTags = new uint[] { 18, 10, 26, 34 };
      public static ProvisionMessage DefaultInstance {
        get { return defaultInstance; }
      }
      
      public override ProvisionMessage DefaultInstanceForType {
        get { return DefaultInstance; }
      }
      
      protected override ProvisionMessage ThisMessage {
        get { return this; }
      }
      
      public static pbd::MessageDescriptor Descriptor {
        get { return global::libtextsecure.push.ProvisioningProtos.internal__static_textsecure_ProvisionMessage__Descriptor; }
      }
      
      protected override pb::FieldAccess.FieldAccessorTable<ProvisionMessage, ProvisionMessage.Builder> InternalFieldAccessors {
        get { return global::libtextsecure.push.ProvisioningProtos.internal__static_textsecure_ProvisionMessage__FieldAccessorTable; }
      }
      
      public const int IdentityKeyPublicFieldNumber = 1;
      private bool hasIdentityKeyPublic;
      private pb::ByteString identityKeyPublic_ = pb::ByteString.Empty;
      public bool HasIdentityKeyPublic {
        get { return hasIdentityKeyPublic; }
      }
      public pb::ByteString IdentityKeyPublic {
        get { return identityKeyPublic_; }
      }
      
      public const int IdentityKeyPrivateFieldNumber = 2;
      private bool hasIdentityKeyPrivate;
      private pb::ByteString identityKeyPrivate_ = pb::ByteString.Empty;
      public bool HasIdentityKeyPrivate {
        get { return hasIdentityKeyPrivate; }
      }
      public pb::ByteString IdentityKeyPrivate {
        get { return identityKeyPrivate_; }
      }
      
      public const int NumberFieldNumber = 3;
      private bool hasNumber;
      private string number_ = "";
      public bool HasNumber {
        get { return hasNumber; }
      }
      public string Number {
        get { return number_; }
      }
      
      public const int ProvisioningCodeFieldNumber = 4;
      private bool hasProvisioningCode;
      private string provisioningCode_ = "";
      public bool HasProvisioningCode {
        get { return hasProvisioningCode; }
      }
      public string ProvisioningCode {
        get { return provisioningCode_; }
      }
      
      public override bool IsInitialized {
        get {
          return true;
        }
      }
      
      public override void WriteTo(pb::ICodedOutputStream output) {
        CalcSerializedSize();
        string[] field_names = _provisionMessageFieldNames;
        if (hasIdentityKeyPublic) {
          output.WriteBytes(1, field_names[1], IdentityKeyPublic);
        }
        if (hasIdentityKeyPrivate) {
          output.WriteBytes(2, field_names[0], IdentityKeyPrivate);
        }
        if (hasNumber) {
          output.WriteString(3, field_names[2], Number);
        }
        if (hasProvisioningCode) {
          output.WriteString(4, field_names[3], ProvisioningCode);
        }
        UnknownFields.WriteTo(output);
      }
      
      private int memoizedSerializedSize = -1;
      public override int SerializedSize {
        get {
          int size = memoizedSerializedSize;
          if (size != -1) return size;
          return CalcSerializedSize();
        }
      }
      
      private int CalcSerializedSize() {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (hasIdentityKeyPublic) {
          size += pb::CodedOutputStream.ComputeBytesSize(1, IdentityKeyPublic);
        }
        if (hasIdentityKeyPrivate) {
          size += pb::CodedOutputStream.ComputeBytesSize(2, IdentityKeyPrivate);
        }
        if (hasNumber) {
          size += pb::CodedOutputStream.ComputeStringSize(3, Number);
        }
        if (hasProvisioningCode) {
          size += pb::CodedOutputStream.ComputeStringSize(4, ProvisioningCode);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
      public static ProvisionMessage ParseFrom(pb::ByteString data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(byte[] data) {
        return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(global::System.IO.Stream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      public static ProvisionMessage ParseDelimitedFrom(global::System.IO.Stream input) {
        return CreateBuilder().MergeDelimitedFrom(input).BuildParsed();
      }
      public static ProvisionMessage ParseDelimitedFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
        return CreateBuilder().MergeDelimitedFrom(input, extensionRegistry).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(pb::ICodedInputStream input) {
        return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
      }
      public static ProvisionMessage ParseFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
      }
      private ProvisionMessage MakeReadOnly() {
        return this;
      }
      
      public static Builder CreateBuilder() { return new Builder(); }
      public override Builder ToBuilder() { return CreateBuilder(this); }
      public override Builder CreateBuilderForType() { return new Builder(); }
      public static Builder CreateBuilder(ProvisionMessage prototype) {
        return new Builder(prototype);
      }
      
      [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
      public sealed partial class Builder : pb::GeneratedBuilder<ProvisionMessage, Builder> {
        protected override Builder ThisBuilder {
          get { return this; }
        }
        public Builder() {
          result = DefaultInstance;
          resultIsReadOnly = true;
        }
        internal Builder(ProvisionMessage cloneFrom) {
          result = cloneFrom;
          resultIsReadOnly = true;
        }
        
        private bool resultIsReadOnly;
        private ProvisionMessage result;
        
        private ProvisionMessage PrepareBuilder() {
          if (resultIsReadOnly) {
            ProvisionMessage original = result;
            result = new ProvisionMessage();
            resultIsReadOnly = false;
            MergeFrom(original);
          }
          return result;
        }
        
        public override bool IsInitialized {
          get { return result.IsInitialized; }
        }
        
        protected override ProvisionMessage MessageBeingBuilt {
          get { return PrepareBuilder(); }
        }
        
        public override Builder Clear() {
          result = DefaultInstance;
          resultIsReadOnly = true;
          return this;
        }
        
        public override Builder Clone() {
          if (resultIsReadOnly) {
            return new Builder(result);
          } else {
            return new Builder().MergeFrom(result);
          }
        }
        
        public override pbd::MessageDescriptor DescriptorForType {
          get { return global::libtextsecure.push.ProvisioningProtos.ProvisionMessage.Descriptor; }
        }
        
        public override ProvisionMessage DefaultInstanceForType {
          get { return global::libtextsecure.push.ProvisioningProtos.ProvisionMessage.DefaultInstance; }
        }
        
        public override ProvisionMessage BuildPartial() {
          if (resultIsReadOnly) {
            return result;
          }
          resultIsReadOnly = true;
          return result.MakeReadOnly();
        }
        
        public override Builder MergeFrom(pb::IMessage other) {
          if (other is ProvisionMessage) {
            return MergeFrom((ProvisionMessage) other);
          } else {
            base.MergeFrom(other);
            return this;
          }
        }
        
        public override Builder MergeFrom(ProvisionMessage other) {
          if (other == global::libtextsecure.push.ProvisioningProtos.ProvisionMessage.DefaultInstance) return this;
          PrepareBuilder();
          if (other.HasIdentityKeyPublic) {
            IdentityKeyPublic = other.IdentityKeyPublic;
          }
          if (other.HasIdentityKeyPrivate) {
            IdentityKeyPrivate = other.IdentityKeyPrivate;
          }
          if (other.HasNumber) {
            Number = other.Number;
          }
          if (other.HasProvisioningCode) {
            ProvisioningCode = other.ProvisioningCode;
          }
          this.MergeUnknownFields(other.UnknownFields);
          return this;
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input) {
          return MergeFrom(input, pb::ExtensionRegistry.Empty);
        }
        
        public override Builder MergeFrom(pb::ICodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
          PrepareBuilder();
          pb::UnknownFieldSet.Builder unknownFields = null;
          uint tag;
          string field_name;
          while (input.ReadTag(out tag, out field_name)) {
            if(tag == 0 && field_name != null) {
              int field_ordinal = global::System.Array.BinarySearch(_provisionMessageFieldNames, field_name, global::System.StringComparer.Ordinal);
              if(field_ordinal >= 0)
                tag = _provisionMessageFieldTags[field_ordinal];
              else {
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                continue;
              }
            }
            switch (tag) {
              case 0: {
                throw pb::InvalidProtocolBufferException.InvalidTag();
              }
              default: {
                if (pb::WireFormat.IsEndGroupTag(tag)) {
                  if (unknownFields != null) {
                    this.UnknownFields = unknownFields.Build();
                  }
                  return this;
                }
                if (unknownFields == null) {
                  unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
                }
                ParseUnknownField(input, unknownFields, extensionRegistry, tag, field_name);
                break;
              }
              case 10: {
                result.hasIdentityKeyPublic = input.ReadBytes(ref result.identityKeyPublic_);
                break;
              }
              case 18: {
                result.hasIdentityKeyPrivate = input.ReadBytes(ref result.identityKeyPrivate_);
                break;
              }
              case 26: {
                result.hasNumber = input.ReadString(ref result.number_);
                break;
              }
              case 34: {
                result.hasProvisioningCode = input.ReadString(ref result.provisioningCode_);
                break;
              }
            }
          }
          
          if (unknownFields != null) {
            this.UnknownFields = unknownFields.Build();
          }
          return this;
        }
        
        
        public bool HasIdentityKeyPublic {
          get { return result.hasIdentityKeyPublic; }
        }
        public pb::ByteString IdentityKeyPublic {
          get { return result.IdentityKeyPublic; }
          set { SetIdentityKeyPublic(value); }
        }
        public Builder SetIdentityKeyPublic(pb::ByteString value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasIdentityKeyPublic = true;
          result.identityKeyPublic_ = value;
          return this;
        }
        public Builder ClearIdentityKeyPublic() {
          PrepareBuilder();
          result.hasIdentityKeyPublic = false;
          result.identityKeyPublic_ = pb::ByteString.Empty;
          return this;
        }
        
        public bool HasIdentityKeyPrivate {
          get { return result.hasIdentityKeyPrivate; }
        }
        public pb::ByteString IdentityKeyPrivate {
          get { return result.IdentityKeyPrivate; }
          set { SetIdentityKeyPrivate(value); }
        }
        public Builder SetIdentityKeyPrivate(pb::ByteString value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasIdentityKeyPrivate = true;
          result.identityKeyPrivate_ = value;
          return this;
        }
        public Builder ClearIdentityKeyPrivate() {
          PrepareBuilder();
          result.hasIdentityKeyPrivate = false;
          result.identityKeyPrivate_ = pb::ByteString.Empty;
          return this;
        }
        
        public bool HasNumber {
          get { return result.hasNumber; }
        }
        public string Number {
          get { return result.Number; }
          set { SetNumber(value); }
        }
        public Builder SetNumber(string value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasNumber = true;
          result.number_ = value;
          return this;
        }
        public Builder ClearNumber() {
          PrepareBuilder();
          result.hasNumber = false;
          result.number_ = "";
          return this;
        }
        
        public bool HasProvisioningCode {
          get { return result.hasProvisioningCode; }
        }
        public string ProvisioningCode {
          get { return result.ProvisioningCode; }
          set { SetProvisioningCode(value); }
        }
        public Builder SetProvisioningCode(string value) {
          pb::ThrowHelper.ThrowIfNull(value, "value");
          PrepareBuilder();
          result.hasProvisioningCode = true;
          result.provisioningCode_ = value;
          return this;
        }
        public Builder ClearProvisioningCode() {
          PrepareBuilder();
          result.hasProvisioningCode = false;
          result.provisioningCode_ = "";
          return this;
        }
      }
      static ProvisionMessage() {
        object.ReferenceEquals(global::libtextsecure.push.ProvisioningProtos.Descriptor, null);
      }
    }
    
    #endregion
    
  }
}

#endregion Designer generated code
