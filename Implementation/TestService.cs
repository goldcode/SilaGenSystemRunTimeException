using Sila.Contracts;
using Tecan.Sila2;

namespace Implementation
{
    public class TestService : ITestService
    {

        public void Initialize()
        {
            
        }

        public IObservableCommand AcquireImage()
        {
            return ObservableCommands.Create(AcquireMyImageInternal);
        }

        async Task AcquireMyImageInternal(CancellationToken cancellationToken)
        {
            await Task.Delay(1000);
        }

    }
}
