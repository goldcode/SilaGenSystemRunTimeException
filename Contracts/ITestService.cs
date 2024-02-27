
using Tecan.Sila2;

namespace Sila.Contracts
{
    /// <summary>
    /// Service to control the MyrImaging Device.
    /// </summary>
    [SilaFeature]
    public interface ITestService
    {
        /// <summary>
        /// Initialize the hardware of the instrument
        /// </summary>
        void Initialize();

        /// <summary>
        /// acquires an image
        /// </summary>
        /// <returns></returns>
        //[Observable]
        //IObservableCommand AcquireImage();
    }
}
