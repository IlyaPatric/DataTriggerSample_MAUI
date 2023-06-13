using System.Collections.ObjectModel;
using DataTriggerSample.Models;

namespace DataTriggerSample.ViewModels;

public class MainViewModel
{
    public ObservableCollection<WorkStatus> WorkList { get; set; } = new();

    public MainViewModel()
    {
        LoadData();
    }

    private void LoadData()
    {
        WorkList = new ObservableCollection<WorkStatus>
        {
            new WorkStatus(
                "Work 1",
                "My description 1",
                "Done"),
            new WorkStatus(
                "Work 2",
                "My description 2",
                "Progress"),
            new WorkStatus(
                "Work 3",
                "My description 3",
                "Delete")
        };
    }
}