using System;
using System.Collections.Generic;

using Amazon.Lambda.Model;
using Amazon.Lambda.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Lambda
{
    public partial class AmazonLambdaClient : AmazonServiceClient, IAmazonLambda
    {
        /// <summary>
        /// Submits an invocation request to Lambda. Upon receiving the request, Lambda executes
        /// the specified cloud function asynchronously. To see the logs generated by the cloud
        /// function execution, see the CloudWatch logs console.
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeAsync</code> action.
        /// </para>
        /// <para>
        /// The InvokeArgs will be set to an empty json document.
        /// </para>
        /// </summary>
        /// <param name="functionName">The cloud function to invoke.</param>
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="InvalidRequestContentException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ServiceException"/>
        [Obsolete("API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public InvokeAsyncResponse InvokeAsync(string functionName)
        {
            return this.InvokeAsync(functionName, "{}");
        }

        /// <summary>
        /// Submits an invocation request to Lambda. Upon receiving the request, Lambda executes
        /// the specified cloud function asynchronously. To see the logs generated by the cloud
        /// function execution, see the CloudWatch logs console.
        /// <para>
        /// This operation requires permission for the <code>lambda:InvokeAsync</code> action.
        /// </para>
        /// </summary>
        /// <param name="functionName">The cloud function to invoke.</param>
        /// <param name="invokeArgs">A Json document that will be passed to the cloud function.</param>
        /// <returns>The response from the InvokeAsync service method, as returned by Lambda.</returns>
        /// <exception cref="InvalidRequestContentException"/>
        /// <exception cref="ResourceNotFoundException"/>
        /// <exception cref="ServiceException"/>
        [Obsolete("API InvokeAsyncResponse InvokeAsync(InvokeAsyncRequest) is deprecated, use InvokeResponse Invoke(InvokeRequest), or Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead. For .NET Core, Task<InvokeAsyncResponse> InvokeAsyncAsync(InvokeAsyncRequest, CancellationToken) is deprecated, use Task<InvokeResponse> InvokeAsync(InvokeRequest, CancellationToken) instead.")]
        public InvokeAsyncResponse InvokeAsync(string functionName, string invokeArgs)
        {
#pragma warning disable 618
            return this.InvokeAsync(new InvokeAsyncRequest { FunctionName = functionName, InvokeArgs = invokeArgs });
#pragma warning restore 618
        }
    }
}