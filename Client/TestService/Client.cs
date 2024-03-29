//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Linq;
using Tecan.Sila2;
using Tecan.Sila2.Client;
using Tecan.Sila2.Server;

namespace SiLAGen.Client.TestService
{
    
    
    /// <summary>
    /// Class that implements the ITestService interface through SiLA2
    /// </summary>
    public partial class TestServiceClient : ITestService
    {
        
        private IClientExecutionManager _executionManager;
        
        private IClientChannel _channel;
        
        private const string _serviceName = "sila2.sila.contracts.testservice.v1.TestService";
        
        /// <summary>
        /// Creates a new instance
        /// </summary>
        /// <param name="channel">The channel through which calls should be executed</param>
        /// <param name="executionManager">A component to determine metadata to attach to any requests</param>
        public TestServiceClient(IClientChannel channel, IClientExecutionManager executionManager)
        {
            _executionManager = executionManager;
            _channel = channel;
        }
        
        public virtual void Initialize()
        {
            InitializeRequestDto request = new InitializeRequestDto(null);
            request.Validate();
            Tecan.Sila2.Client.IClientCallInfo callInfo = _executionManager.CreateCallOptions("sila/contracts/TestService/v1/Command/Initialize");
            try
            {
                _channel.ExecuteUnobservableCommand<InitializeRequestDto>(_serviceName, "Initialize", request, callInfo);
                callInfo.FinishSuccessful();
                return;
            } catch (System.Exception ex)
            {
                System.Exception exception = _channel.ConvertException(ex);
                callInfo.FinishWithErrors(exception);
                throw exception;
            }
        }
        
        private T Extract<T>(Tecan.Sila2.ISilaTransferObject<T> dto)
        
        {
            return dto.Extract(_executionManager.DownloadBinaryStore);
        }
    }
    
    /// <summary>
    /// Factory to instantiate clients for the Test Service.
    /// </summary>
    [System.ComponentModel.Composition.ExportAttribute(typeof(IClientFactory))]
    [System.ComponentModel.Composition.PartCreationPolicyAttribute(System.ComponentModel.Composition.CreationPolicy.Shared)]
    public partial class TestServiceClientFactory : IClientFactory
    {
        
        /// <summary>
        /// Gets the fully-qualified identifier of the feature for which clients can be generated
        /// </summary>
        public string FeatureIdentifier
        {
            get
            {
                return "sila/contracts/TestService/v1";
            }
        }
        
        /// <summary>
        /// Gets the interface type for which clients can be generated
        /// </summary>
        public System.Type InterfaceType
        {
            get
            {
                return typeof(ITestService);
            }
        }
        
        /// <summary>
        /// Creates a strongly typed client for the given execution channel and execution manager
        /// </summary>
        /// <param name="channel">The channel that should be used for communication with the server</param>
        /// <param name="executionManager">The execution manager to manage metadata</param>
        /// <returns>A strongly typed client. This object will be an instance of the InterfaceType property</returns>
        public object CreateClient(IClientChannel channel, IClientExecutionManager executionManager)
        {
            return new TestServiceClient(channel, executionManager);
        }
    }
}

