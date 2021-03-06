// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: LocalizationService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace MockSite.Message {
  public static partial class LocalizationService
  {
    static readonly string __ServiceName = "Account.LocalizationService";

    static readonly grpc::Marshaller<global::MockSite.Message.Language> __Marshaller_Account_Language = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MockSite.Message.Language.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MockSite.Message.BaseResponse> __Marshaller_Common_BaseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MockSite.Message.BaseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MockSite.Message.Empty> __Marshaller_Common_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MockSite.Message.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MockSite.Message.Languages> __Marshaller_Account_Languages = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MockSite.Message.Languages.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MockSite.Message.QueryLanguageMessage> __Marshaller_Account_QueryLanguageMessage = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MockSite.Message.QueryLanguageMessage.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::MockSite.Message.LanguageSet> __Marshaller_Account_LanguageSet = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::MockSite.Message.LanguageSet.Parser.ParseFrom);

    static readonly grpc::Method<global::MockSite.Message.Language, global::MockSite.Message.BaseResponse> __Method_Modify = new grpc::Method<global::MockSite.Message.Language, global::MockSite.Message.BaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Modify",
        __Marshaller_Account_Language,
        __Marshaller_Common_BaseResponse);

    static readonly grpc::Method<global::MockSite.Message.Empty, global::MockSite.Message.Languages> __Method_GetAll = new grpc::Method<global::MockSite.Message.Empty, global::MockSite.Message.Languages>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAll",
        __Marshaller_Common_Empty,
        __Marshaller_Account_Languages);

    static readonly grpc::Method<global::MockSite.Message.QueryLanguageMessage, global::MockSite.Message.LanguageSet> __Method_Get = new grpc::Method<global::MockSite.Message.QueryLanguageMessage, global::MockSite.Message.LanguageSet>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Get",
        __Marshaller_Account_QueryLanguageMessage,
        __Marshaller_Account_LanguageSet);

    static readonly grpc::Method<global::MockSite.Message.QueryLanguageMessage, global::MockSite.Message.BaseResponse> __Method_Delete = new grpc::Method<global::MockSite.Message.QueryLanguageMessage, global::MockSite.Message.BaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Delete",
        __Marshaller_Account_QueryLanguageMessage,
        __Marshaller_Common_BaseResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::MockSite.Message.LocalizationServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of LocalizationService</summary>
    [grpc::BindServiceMethod(typeof(LocalizationService), "BindService")]
    public abstract partial class LocalizationServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::MockSite.Message.BaseResponse> Modify(global::MockSite.Message.Language request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::MockSite.Message.Languages> GetAll(global::MockSite.Message.Empty request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::MockSite.Message.LanguageSet> Get(global::MockSite.Message.QueryLanguageMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::MockSite.Message.BaseResponse> Delete(global::MockSite.Message.QueryLanguageMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for LocalizationService</summary>
    public partial class LocalizationServiceClient : grpc::ClientBase<LocalizationServiceClient>
    {
      /// <summary>Creates a new client for LocalizationService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public LocalizationServiceClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for LocalizationService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public LocalizationServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected LocalizationServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected LocalizationServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::MockSite.Message.BaseResponse Modify(global::MockSite.Message.Language request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Modify(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MockSite.Message.BaseResponse Modify(global::MockSite.Message.Language request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Modify, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.BaseResponse> ModifyAsync(global::MockSite.Message.Language request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ModifyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.BaseResponse> ModifyAsync(global::MockSite.Message.Language request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Modify, null, options, request);
      }
      public virtual global::MockSite.Message.Languages GetAll(global::MockSite.Message.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MockSite.Message.Languages GetAll(global::MockSite.Message.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAll, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.Languages> GetAllAsync(global::MockSite.Message.Empty request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.Languages> GetAllAsync(global::MockSite.Message.Empty request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAll, null, options, request);
      }
      public virtual global::MockSite.Message.LanguageSet Get(global::MockSite.Message.QueryLanguageMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Get(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MockSite.Message.LanguageSet Get(global::MockSite.Message.QueryLanguageMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Get, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.LanguageSet> GetAsync(global::MockSite.Message.QueryLanguageMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.LanguageSet> GetAsync(global::MockSite.Message.QueryLanguageMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Get, null, options, request);
      }
      public virtual global::MockSite.Message.BaseResponse Delete(global::MockSite.Message.QueryLanguageMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Delete(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::MockSite.Message.BaseResponse Delete(global::MockSite.Message.QueryLanguageMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Delete, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.BaseResponse> DeleteAsync(global::MockSite.Message.QueryLanguageMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::MockSite.Message.BaseResponse> DeleteAsync(global::MockSite.Message.QueryLanguageMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Delete, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override LocalizationServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new LocalizationServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(LocalizationServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Modify, serviceImpl.Modify)
          .AddMethod(__Method_GetAll, serviceImpl.GetAll)
          .AddMethod(__Method_Get, serviceImpl.Get)
          .AddMethod(__Method_Delete, serviceImpl.Delete).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, LocalizationServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Modify, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MockSite.Message.Language, global::MockSite.Message.BaseResponse>(serviceImpl.Modify));
      serviceBinder.AddMethod(__Method_GetAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MockSite.Message.Empty, global::MockSite.Message.Languages>(serviceImpl.GetAll));
      serviceBinder.AddMethod(__Method_Get, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MockSite.Message.QueryLanguageMessage, global::MockSite.Message.LanguageSet>(serviceImpl.Get));
      serviceBinder.AddMethod(__Method_Delete, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::MockSite.Message.QueryLanguageMessage, global::MockSite.Message.BaseResponse>(serviceImpl.Delete));
    }

  }
}
#endregion
