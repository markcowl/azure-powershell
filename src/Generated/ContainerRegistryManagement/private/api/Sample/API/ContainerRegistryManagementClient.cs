namespace Sample.API
{
    using static Microsoft.Rest.ClientRuntime.IEventListenerExtensions;
    public class ContainerRegistryManagementClient
    {
        public Microsoft.Rest.ClientRuntime.ISendAsync Sender {get;set;}
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task OperationsList(string apiVersion, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IOperationListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//providers/Microsoft.ContainerRegistry/operations?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.OperationsList_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task OperationsList_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IOperationListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IOperationListResult>(async () => Sample.API.Models.OperationListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task OperationsList_Validate(string apiVersion, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="body"> The object containing information for the availability request. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesCheckNameAvailability(string apiVersion, string subscriptionId, Sample.API.Models.IRegistryNameCheckRequest body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryNameStatus> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/providers/Microsoft.ContainerRegistry/checkNameAvailability?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesCheckNameAvailability_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesCheckNameAvailability_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryNameStatus> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistryNameStatus>(async () => Sample.API.Models.RegistryNameStatus.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="body"> The object containing information for the availability request. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesCheckNameAvailability_Validate(string apiVersion, string subscriptionId, Sample.API.Models.IRegistryNameCheckRequest body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> The parameters for creating a container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesCreate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IRegistry body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Put, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesCreate_Call(request,on200,on201,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesCreate_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistry>(async () => Sample.API.Models.Registry.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)201:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on201( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistry>(async () => Sample.API.Models.Registry.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> The parameters for creating a container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesCreate_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IRegistry body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="on204"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesDelete(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.OnResponse on204, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Delete, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesDelete_Call(request,on200,on202,on204,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="on204"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesDelete_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.OnResponse on204, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)202:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on202(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)204:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on204(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesDelete_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesGet(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesGet_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesGet_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistry>(async () => Sample.API.Models.Registry.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesGet_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> The parameters specifying the image to copy and the source container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesImportImage(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IImportImageParameters body, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/importImage?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesImportImage_Call(request,on200,on202,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesImportImage_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)202:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on202(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> The parameters specifying the image to copy and the source container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesImportImage_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IImportImageParameters body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesList(string apiVersion, string subscriptionId, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/providers/Microsoft.ContainerRegistry/registries?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesList_Call(request,on200,listener,sender);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesListByResourceGroup(string apiVersion, string subscriptionId, string resourceGroupName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesListByResourceGroup_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesListByResourceGroup_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistryListResult>(async () => Sample.API.Models.RegistryListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesListByResourceGroup_Validate(string apiVersion, string subscriptionId, string resourceGroupName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesListCredentials(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListCredentialsResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/listCredentials?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesListCredentials_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesListCredentials_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListCredentialsResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistryListCredentialsResult>(async () => Sample.API.Models.RegistryListCredentialsResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesListCredentials_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesListUsages(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryUsageListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/listUsages?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesListUsages_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesListUsages_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryUsageListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistryUsageListResult>(async () => Sample.API.Models.RegistryUsageListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesListUsages_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesList_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistryListResult>(async () => Sample.API.Models.RegistryListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesList_Validate(string apiVersion, string subscriptionId, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> Specifies name of the password which should be regenerated -- password or password2. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesRegenerateCredential(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IRegenerateCredentialParameters body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListCredentialsResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/regenerateCredential?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesRegenerateCredential_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesRegenerateCredential_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistryListCredentialsResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistryListCredentialsResult>(async () => Sample.API.Models.RegistryListCredentialsResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> Specifies name of the password which should be regenerated -- password or password2. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesRegenerateCredential_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IRegenerateCredentialParameters body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> The parameters for updating a container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task RegistriesUpdate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IRegistryUpdateParameters body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Patch, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.RegistriesUpdate_Call(request,on200,on201,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task RegistriesUpdate_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IRegistry> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistry>(async () => Sample.API.Models.Registry.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)201:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on201( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IRegistry>(async () => Sample.API.Models.Registry.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="body"> The parameters for updating a container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task RegistriesUpdate_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Sample.API.Models.IRegistryUpdateParameters body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="body"> The parameters for creating a replication. </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task ReplicationsCreate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Sample.API.Models.IReplication body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/replications/{System.Uri.EscapeDataString(replicationName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Put, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.ReplicationsCreate_Call(request,on200,on201,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task ReplicationsCreate_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IReplication>(async () => Sample.API.Models.Replication.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)201:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on201( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IReplication>(async () => Sample.API.Models.Replication.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="body"> The parameters for creating a replication. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task ReplicationsCreate_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Sample.API.Models.IReplication body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(replicationName),replicationName);
            await listener.AssertMinimumLength(nameof(replicationName),replicationName,5);
            await listener.AssertMaximumLength(nameof(replicationName),replicationName,5);
            await listener.AssertRegEx(nameof(replicationName),replicationName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="on204"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task ReplicationsDelete(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.OnResponse on204, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/replications/{System.Uri.EscapeDataString(replicationName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Delete, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.ReplicationsDelete_Call(request,on200,on202,on204,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="on204"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task ReplicationsDelete_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.OnResponse on204, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)202:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on202(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)204:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on204(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task ReplicationsDelete_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(replicationName),replicationName);
            await listener.AssertMinimumLength(nameof(replicationName),replicationName,5);
            await listener.AssertMaximumLength(nameof(replicationName),replicationName,5);
            await listener.AssertRegEx(nameof(replicationName),replicationName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task ReplicationsGet(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/replications/{System.Uri.EscapeDataString(replicationName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.ReplicationsGet_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task ReplicationsGet_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IReplication>(async () => Sample.API.Models.Replication.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task ReplicationsGet_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(replicationName),replicationName);
            await listener.AssertMinimumLength(nameof(replicationName),replicationName,5);
            await listener.AssertMaximumLength(nameof(replicationName),replicationName,5);
            await listener.AssertRegEx(nameof(replicationName),replicationName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task ReplicationsList(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplicationListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/replications?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.ReplicationsList_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task ReplicationsList_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplicationListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IReplicationListResult>(async () => Sample.API.Models.ReplicationListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task ReplicationsList_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="body"> The parameters for updating a replication. </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task ReplicationsUpdate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Sample.API.Models.IReplicationUpdateParameters body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/replications/{System.Uri.EscapeDataString(replicationName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Patch, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.ReplicationsUpdate_Call(request,on200,on201,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task ReplicationsUpdate_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IReplication> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IReplication>(async () => Sample.API.Models.Replication.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)201:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on201( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IReplication>(async () => Sample.API.Models.Replication.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="replicationName"> The name of the replication. </param>
        /// <param name="body"> The parameters for updating a replication. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task ReplicationsUpdate_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string replicationName, Sample.API.Models.IReplicationUpdateParameters body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(replicationName),replicationName);
            await listener.AssertMinimumLength(nameof(replicationName),replicationName,5);
            await listener.AssertMaximumLength(nameof(replicationName),replicationName,5);
            await listener.AssertRegEx(nameof(replicationName),replicationName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="body"> The parameters for creating a webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksCreate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Sample.API.Models.IWebhookCreateParameters body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Put, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksCreate_Call(request,on200,on201,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksCreate_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IWebhook>(async () => Sample.API.Models.Webhook.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)201:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on201( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IWebhook>(async () => Sample.API.Models.Webhook.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="body"> The parameters for creating a webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksCreate_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Sample.API.Models.IWebhookCreateParameters body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="on204"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksDelete(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.OnResponse on204, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Delete, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksDelete_Call(request,on200,on202,on204,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on202"> </param>
        /// <param name="on204"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksDelete_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse on200, Microsoft.Rest.ClientRuntime.OnResponse on202, Microsoft.Rest.ClientRuntime.OnResponse on204, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)202:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on202(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)204:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on204(new Microsoft.Rest.ClientRuntime.Response(){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksDelete_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksGet(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksGet_Call(request,on200,listener,sender);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksGetCallbackConfig(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.ICallbackConfig> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}/getCallbackConfig?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksGetCallbackConfig_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksGetCallbackConfig_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.ICallbackConfig> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.ICallbackConfig>(async () => Sample.API.Models.CallbackConfig.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksGetCallbackConfig_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksGet_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IWebhook>(async () => Sample.API.Models.Webhook.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksGet_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksList(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhookListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Get, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksList_Call(request,on200,listener,sender);
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksListEvents(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IEventListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}/listEvents?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksListEvents_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksListEvents_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IEventListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IEventListResult>(async () => Sample.API.Models.EventListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksListEvents_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksList_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhookListResult> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IWebhookListResult>(async () => Sample.API.Models.WebhookListResult.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksList_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksPing(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IEventInfo> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}/ping?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Post, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksPing_Call(request,on200,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksPing_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IEventInfo> on200, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IEventInfo>(async () => Sample.API.Models.EventInfo.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksPing_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
        }
        /// <summary>MISSING DESCRIPTION 05</summary>
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="body"> The parameters for updating a webhook. </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        public async System.Threading.Tasks.Task WebhooksUpdate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Sample.API.Models.IWebhookUpdateParameters body, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            // should we call validation?
            // construct URL
            var _url = $"https://management.azure.com//subscriptions/{System.Uri.EscapeDataString(subscriptionId)}/resourceGroups/{System.Uri.EscapeDataString(resourceGroupName)}/providers/Microsoft.ContainerRegistry/registries/{System.Uri.EscapeDataString(registryName)}/webhooks/{System.Uri.EscapeDataString(webhookName)}?api-version={System.Uri.EscapeDataString(apiVersion)}";
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.URLCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // generate request object
            var request =  new System.Net.Http.HttpRequestMessage(Microsoft.Rest.ClientRuntime.Method.Patch, _url);
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.RequestCreated, _url); if( listener.Token.IsCancellationRequested ) { return; }
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.HeaderParametersAdded, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // set body content
            request.Content = new System.Net.Http.StringContent( null != body ? body.ToJson(null) : "{}", System.Text.Encoding.UTF8);
            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json; charset=utf-8");
            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BodyContentSet, _url); if( listener.Token.IsCancellationRequested ) { return; }
            // make the call
            await this.WebhooksUpdate_Call(request,on200,on201,listener,sender);
        }
        /// <param name="request"> </param>
        /// <param name="on200"> </param>
        /// <param name="on201"> </param>
        /// <param name="listener"> </param>
        /// <param name="sender"> </param>
        internal async System.Threading.Tasks.Task WebhooksUpdate_Call(System.Net.Http.HttpRequestMessage request, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on200, Microsoft.Rest.ClientRuntime.OnResponse<Sample.API.Models.IWebhook> on201, Microsoft.Rest.ClientRuntime.IEventListener listener, Microsoft.Rest.ClientRuntime.ISendAsync sender)
        {
            using( request )
            {
                System.Net.Http.HttpResponseMessage _response = null;
                try
                {
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeCall, request); if( listener.Token.IsCancellationRequested ) { return; }
                    _response = await sender.SendAsync(request,  listener);
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.ResponseCreated, _response); if( listener.Token.IsCancellationRequested ) { return; }
                    var _contentType = (_response.Headers.TryGetValues("Content-Type", out var values) ? System.Linq.Enumerable.FirstOrDefault(values) : string.Empty).ToLowerInvariant();
                    switch( _response.StatusCode )
                    {
                        case (System.Net.HttpStatusCode)200:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on200( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IWebhook>(async () => Sample.API.Models.Webhook.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        case (System.Net.HttpStatusCode)201:
                            await listener.Signal(Microsoft.Rest.ClientRuntime.Events.BeforeResponseDispatch, _response); if( listener.Token.IsCancellationRequested ) { return; }
                            await on201( new Microsoft.Rest.ClientRuntime.Response<Sample.API.Models.IWebhook>(async () => Sample.API.Models.Webhook.FromJson(Carbon.Json.JsonNode.Parse( await _response.Content.ReadAsStringAsync() )) ){ RequestMessage = request,ResponseMessage = _response });
                            break;
                        default:
                            throw new Microsoft.Rest.ClientRuntime.UndeclaredResponseException(_response.StatusCode);
                    }
                }
                finally
                {
                    // finally statements
                    await listener.Signal(Microsoft.Rest.ClientRuntime.Events.Finally, request, _response);
                    _response?.Dispose();
                }
            }
        }
        /// <param name="apiVersion"> The client API version. </param>
        /// <param name="subscriptionId"> The Microsoft Azure subscription ID. </param>
        /// <param name="resourceGroupName"> The name of the resource group to which the container registry belongs. </param>
        /// <param name="registryName"> The name of the container registry. </param>
        /// <param name="webhookName"> The name of the webhook. </param>
        /// <param name="body"> The parameters for updating a webhook. </param>
        /// <param name="listener"> </param>
        internal async System.Threading.Tasks.Task WebhooksUpdate_Validate(string apiVersion, string subscriptionId, string resourceGroupName, string registryName, string webhookName, Sample.API.Models.IWebhookUpdateParameters body, Microsoft.Rest.ClientRuntime.IEventListener listener)
        {
            await listener.AssertNotNull(nameof(apiVersion),apiVersion);
            await listener.AssertNotNull(nameof(subscriptionId),subscriptionId);
            await listener.AssertNotNull(nameof(resourceGroupName),resourceGroupName);
            await listener.AssertNotNull(nameof(registryName),registryName);
            await listener.AssertMinimumLength(nameof(registryName),registryName,5);
            await listener.AssertMaximumLength(nameof(registryName),registryName,5);
            await listener.AssertRegEx(nameof(registryName),registryName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(webhookName),webhookName);
            await listener.AssertMinimumLength(nameof(webhookName),webhookName,5);
            await listener.AssertMaximumLength(nameof(webhookName),webhookName,5);
            await listener.AssertRegEx(nameof(webhookName),webhookName,@"^[a-zA-Z0-9]*$");
            await listener.AssertNotNull(nameof(body), body);
            await listener.AssertObjectIsValid(nameof(body), body);
        }
    }
}