using DataTriggerSample.ViewModels;

namespace DataTriggerSample;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new MainViewModel();
    }
}