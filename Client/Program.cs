// See https://aka.ms/new-console-template for more information


using SiLAGen.Client.TestService;
using Tecan.Sila2.Discovery;

var connector = new ServerConnector(new DiscoveryExecutionManager());
var discovery = new ServerDiscovery(connector);
var executionManagerFactory = new DiscoveryExecutionManager();

var server = discovery
    .GetServers(TimeSpan.FromSeconds(3), nic => true)
    .First();

var silaClient = new TestServiceClient(server.Channel, executionManagerFactory);
silaClient.Initialize();