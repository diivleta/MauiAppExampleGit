using MauiAppExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Profile;

namespace MauiAppExample.Platforms
{
    public class DeviceInfoService : IDeviceInfoService
    {
        public string GetDeviceName()
        {
            return $"Windows - {AnalyticsInfo.VersionInfo.DeviceFamily}";
        }
    }
}
