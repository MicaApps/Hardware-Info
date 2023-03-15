using System.Collections.ObjectModel;
using HardwareInfo.Models;
using HardwareInfo.Services;
using HardwareInfo.ViewModels;
using LibreHardwareMonitor.Hardware;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Windows.AI.MachineLearning;
using Windows.Devices.Sensors;
using SensorType = LibreHardwareMonitor.Hardware.SensorType;

namespace HardwareInfo.Views;

public sealed partial class BlankPage : Page
{
    public BlankViewModel ViewModel
    {
        get;
    }
    public BlankPage()
    {
        ViewModel = App.GetService<BlankViewModel>();
        InitializeComponent();
        lv_hardware.ItemsSource = HardwareInfoService.source; 
        lv_hardwaredetail.ItemsSource = HardwareInfoService.source2;
    }

    private void lv_hardware_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        HardwareInfoService.SeletedIndex = lv_hardware.SelectedIndex;
        HardwareInfoService.source2[0] = HardwareInfoService.source[HardwareInfoService.SeletedIndex];
    }
}
