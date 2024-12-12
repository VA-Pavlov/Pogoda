using Pogoda.Views.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Pogoda.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ICommand HomeCommand { get; }
        public ICommand LocationCommand { get; }
        public ICommand SettingsCommand { get; }
        public ICommand ClouseCommand { get; }

        private ViewModelBase selectedContent;
        public ViewModelBase SelectedContent
        {
            get { return selectedContent; }
            set
            {
                selectedContent = value;
                OnPropertyCanged();
            }
        } 
        public MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(OpenHomeView , CanOpenHomeView);
            LocationCommand = new RelayCommand(OpenLocationView, CanOpenLocationView);
            SettingsCommand = new RelayCommand(OpenSettingsView, CanOpenSettingsView);
            ClouseCommand = new RelayCommand(OpenClouseView, CanOpenClouseView);
        }
        private void OpenHomeView(object obj)
        {
            SelectedContent = new HomeViewViewModel();
        }
        private bool CanOpenHomeView(object arg)
        {
            return true;
        }

        private void OpenLocationView(object obj)
        {
            SelectedContent = new LocationViewViewModel();
        }
        private bool CanOpenLocationView(object arg)
        {
            return true;
        }
        
        private void OpenSettingsView(object obj)
        {
            SelectedContent = new SettingsViewViewModel();
        }
        private bool CanOpenSettingsView(object arg)
        {
            return true;
        }

        private void OpenClouseView(object obj)
        {
            Application.Current.MainWindow.Close();
        }
        private bool CanOpenClouseView(object arg)
        {
            return true;
        }
    }
}
