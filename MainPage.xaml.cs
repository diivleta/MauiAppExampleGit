using MauiAppExample.Interface;

namespace MauiAppExample
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public IDeviceInfoService deviceService { get; set; }

        public MainPage(IDeviceInfoService service)
        {
            InitializeComponent();

            deviceService = service;
        }

        private void OnCounterClicked(object? sender, EventArgs e)
        {
            CounterBtn.Text = $"Your device is: {deviceService.GetDeviceName()}";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}
