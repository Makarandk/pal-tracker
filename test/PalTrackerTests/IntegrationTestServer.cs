using PalTracker;
using Microsoft.AspNetCore.TestHost;


namespace PalTrackerTests
{
    public static class IntegrationTestServer
    {
      public static TestServer Start() =>
            new TestServer(Program.CreateWebHostBuilder(new string[] { })); 
    }
}