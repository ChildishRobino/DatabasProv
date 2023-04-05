using CaseManagerApp.MVVM.Models;
using CaseManagerApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace CaseManagerApp.MVVM.ViewModels;

public partial class CasesViewModel : ObservableObject
{

    [ObservableProperty]
    private string title = "Ärenden";

    [ObservableProperty]
    private CaseModel selectedCase = null!;


    [ObservableProperty]
    private string? comment;

    [ObservableProperty]
    private string? status;

    [ObservableProperty]
    private ObservableCollection<CaseModel> caseList = null!;



    public CasesViewModel()
    {
        _ = LoadAllCasesAsync();

    }

    public async Task LoadAllCasesAsync()
    {
        IEnumerable<CaseModel> cases = await CaseService.GetAllAsync();
        CaseList = new ObservableCollection<CaseModel>(cases);

    }

    [RelayCommand]
    private async Task AddComment()
    {
        var caseId = SelectedCase.CaseId;
        string text = Comment!;
        await CaseService.AddCommentAsync(text!, caseId);
        Comment = string.Empty;
    }

    [RelayCommand]
    private async Task StatusToStarted()
    {
        var caseId = SelectedCase.CaseId;
        await CaseService.StatusToStartedAsync(caseId);
        Status = "Påbörjad";
        SelectedCase.Status = "Påbörjad";
    }

    [RelayCommand]
    private async Task StatusToFinished()
    {
        var caseId = SelectedCase.CaseId;
        await CaseService.StatusToFinishedAsync(caseId);
        Status = "Avslutad";
        SelectedCase.Status = "Avslutad";
    }



}
