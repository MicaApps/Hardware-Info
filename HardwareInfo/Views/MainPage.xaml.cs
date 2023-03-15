using HardwareInfo.Services;
using HardwareInfo.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace HardwareInfo.Views;

public sealed partial class MainPage : Page
{
    public MainViewModel ViewModel
    {
        get;
    }

    public MainPage()
    {
        ViewModel = App.GetService<MainViewModel>();
        InitializeComponent();
        lv_cpu.ItemsSource = HardwareInfoService.cpu_source;
        lv_mem.ItemsSource = HardwareInfoService.mem_source;
        lv_gpu.ItemsSource = HardwareInfoService.gpu_source;
        lv_temp.ItemsSource = HardwareInfoService.temp_source;
    }
}
