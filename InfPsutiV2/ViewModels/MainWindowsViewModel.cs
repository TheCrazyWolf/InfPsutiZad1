using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfPsutiV2.ViewModels
{
    partial class MainWindowsViewModel : ObservableObject
    {
        [ObservableProperty] private DateTime dateTime;
        [ObservableProperty] private string family;
        [ObservableProperty] private DateTime dateBirhday;
        [ObservableProperty] private int days;
        [ObservableProperty] private string result;


        [RelayCommand]
        private void Do()
        {
            Result = $"Вы {Family}\n" +
                $"Вы прожили {(dateBirhday.Year - dateTime.Year) * 365}\n" +
                $"Вы хотите учится {(dateTime.Year - dateTime.AddDays(days).Year) * 365} \n" +
                $"Вы станете умным {dateTime.AddDays(days).Date} \n" +
                $"Это будет {dateTime.AddDays(days).DayOfWeek}";
        }
    }
}
