using CaseManagerApp.MVVM.Models;
using CaseManagerApp.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseManagerApp.MVVM.ViewModels;

public partial class AddCaseViewModel : ObservableObject
{
    [ObservableProperty]
    private  string  pageTitle = "Lägg till nytt ärende";

    [ObservableProperty]
    private string? firstName;

    [ObservableProperty]
    private string lastName = null!;

    [ObservableProperty]
    private string email = null!;

    [ObservableProperty]
    private string phoneNumber = null!;

    [ObservableProperty]
    private string streetName = null!;

    [ObservableProperty]
    private string postalCode = null!;

    [ObservableProperty]
    private string city = null!;

    [ObservableProperty]
    private string description = null!;


    [RelayCommand]
    private async Task AddCase()
    {
        await CaseService.SaveAsync(
            new CaseModel
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                PhoneNumber = phoneNumber,
                StreetName = streetName,
                PostalCode = postalCode,
                City = city,
                Description = description
                
            }
            );

        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        PhoneNumber = string.Empty;
        StreetName = string.Empty;
        PostalCode = string.Empty;
        City = string.Empty;
        Description = string.Empty;
    }
}



