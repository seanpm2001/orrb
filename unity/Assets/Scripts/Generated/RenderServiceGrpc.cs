// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: orrb/protos/RenderService.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Orrb {
  public static partial class RenderService
  {
    static readonly string __ServiceName = "orrb.RenderService";

    static readonly grpc::Marshaller<global::Orrb.RenderBatchRequest> __Marshaller_orrb_RenderBatchRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Orrb.RenderBatchRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Orrb.RenderBatchResponse> __Marshaller_orrb_RenderBatchResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Orrb.RenderBatchResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Orrb.UpdateRequest> __Marshaller_orrb_UpdateRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Orrb.UpdateRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Orrb.UpdateResponse> __Marshaller_orrb_UpdateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Orrb.UpdateResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Orrb.RenderBatchRequest, global::Orrb.RenderBatchResponse> __Method_RenderBatch = new grpc::Method<global::Orrb.RenderBatchRequest, global::Orrb.RenderBatchResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RenderBatch",
        __Marshaller_orrb_RenderBatchRequest,
        __Marshaller_orrb_RenderBatchResponse);

    static readonly grpc::Method<global::Orrb.UpdateRequest, global::Orrb.UpdateResponse> __Method_Update = new grpc::Method<global::Orrb.UpdateRequest, global::Orrb.UpdateResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Update",
        __Marshaller_orrb_UpdateRequest,
        __Marshaller_orrb_UpdateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Orrb.RenderServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of RenderService</summary>
    public abstract partial class RenderServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Orrb.RenderBatchResponse> RenderBatch(global::Orrb.RenderBatchRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Orrb.UpdateResponse> Update(global::Orrb.UpdateRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for RenderService</summary>
    public partial class RenderServiceClient : grpc::ClientBase<RenderServiceClient>
    {
      /// <summary>Creates a new client for RenderService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public RenderServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for RenderService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public RenderServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected RenderServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected RenderServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Orrb.RenderBatchResponse RenderBatch(global::Orrb.RenderBatchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RenderBatch(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Orrb.RenderBatchResponse RenderBatch(global::Orrb.RenderBatchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RenderBatch, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Orrb.RenderBatchResponse> RenderBatchAsync(global::Orrb.RenderBatchRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RenderBatchAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Orrb.RenderBatchResponse> RenderBatchAsync(global::Orrb.RenderBatchRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RenderBatch, null, options, request);
      }
      public virtual global::Orrb.UpdateResponse Update(global::Orrb.UpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Update(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Orrb.UpdateResponse Update(global::Orrb.UpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Update, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Orrb.UpdateResponse> UpdateAsync(global::Orrb.UpdateRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Orrb.UpdateResponse> UpdateAsync(global::Orrb.UpdateRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Update, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override RenderServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new RenderServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(RenderServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_RenderBatch, serviceImpl.RenderBatch)
          .AddMethod(__Method_Update, serviceImpl.Update).Build();
    }

  }
}
#endregion
