using CommunityToolkit.Mvvm.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GusData.Interfaces;
using GusData.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GusData.Viewmodel
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private readonly IGusDataService service;
        [ObservableProperty]
        private ObservableCollection<Section> _listOfSections = new();

        public MainWindowViewModel(IGusDataService service)
        {
            this.service = service;
        }

        [RelayCommand]
        private async void GetData()
        {
            ListOfSections = await service.GetData();
        }
    }
}
