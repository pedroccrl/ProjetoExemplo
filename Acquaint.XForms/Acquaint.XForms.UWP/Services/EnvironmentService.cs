using Acquaint.XForms.UWP;

[assembly: Xamarin.Forms.Dependency(typeof(EnvironmentService))]

namespace Acquaint.XForms.UWP
{
    public class EnvironmentService : IEnvironmentService
    {
        public bool IsRealDevice
        {
            get
            {
                Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation deviceInfo = new Windows.Security.ExchangeActiveSyncProvisioning.EasClientDeviceInformation();
                return (deviceInfo.SystemProductName != "Virtual");
            }
        }
    }
}