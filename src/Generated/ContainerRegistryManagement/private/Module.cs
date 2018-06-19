namespace Sample.API
{
    using SignalDelegate = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>;
    using GetParameterDelegate = System.Func<string, System.Collections.Generic.Dictionary<string,object>, string, object>;
    using SendAsyncStepDelegate = System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;
    using PipelineChangeDelegate = System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>;
    using NextDelegate = System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;
    using ModuleLoadPipelineDelegate = System.Action<string, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>>;
    using NewRequestPipelineDelegate = System.Action<System.Collections.Generic.Dictionary<string,object>, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>, System.Action<System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>>>;
    public class Module
    {
        private Microsoft.Rest.ClientRuntime.HttpPipeline _pipeline;
        public Sample.API.ContainerRegistryManagementClient ClientAPI {get;set;}
        public SignalDelegate EventListener {get;set;}
        public GetParameterDelegate GetParameterValue {get;set;}
        /// <summary>Backing field for Instance property</summary>
        private static Sample.API.Module _instance;

        public static Sample.API.Module Instance => Sample.API.Module._instance?? (Sample.API.Module._instance = new Sample.API.Module());
        public string Name => @"ContainerRegistryManagement";
        public ModuleLoadPipelineDelegate OnModuleLoad {get;set;}
        public NewRequestPipelineDelegate OnNewRequest {get;set;}
        /// <param name="boundParameters"> </param>
        public Microsoft.Rest.ClientRuntime.HttpPipeline CreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParameters)
        {
            var result = this._pipeline.Clone();
            if(OnNewRequest != null)
            {
                OnNewRequest( boundParameters, (step)=> { result.Prepend(step); } , (step)=> { result.Append(step); } );
            }
            return result;
        }
        public void Init()
        {
            if(OnModuleLoad != null)
            {
                OnModuleLoad( Name ,(step)=> { _pipeline.Prepend(step); } , (step)=> { _pipeline.Append(step); } );
            }
        }
        private Module()
        {
            /// constructor
            ClientAPI = new Sample.API.ContainerRegistryManagementClient();
            _pipeline = new Microsoft.Rest.ClientRuntime.HttpPipeline();
        }
        /// <param name="id"> </param>
        /// <param name="token"> </param>
        /// <param name="getEventData"> </param>
        public async System.Threading.Tasks.Task Signal(string id, System.Threading.CancellationToken token, System.Func<System.EventArgs> getEventData)
        {
            if(EventListener != null)
            {
                await EventListener(id,token,getEventData);
            }
        }
    }
}