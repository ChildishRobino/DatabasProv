using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagerApp.MVVM.ViewModels;

public partial class MainViewModel : ObservableObject
{

    [ObservableProperty]
    private ObservableObject currentViewModel;

  
    public MainViewModel()
    {
        CurrentViewModel = new AddCaseViewModel();
    }

    [RelayCommand]
    private void GoToAddCase()
    {
        CurrentViewModel = new AddCaseViewModel();
    }

    [RelayCommand]
    private void GoToCases()
    {
        CurrentViewModel = new CasesViewModel();
    }

}
