using Android.Content;
using Android.Runtime;
using Android.Views;
using MauiAppExample.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiAppExample.Platforms
{

    public class DeviceInfoService : IDeviceInfoService
    {
        public string GetDeviceName()
        {
            return Android.OS.Build.Model;
        }
    }
}
