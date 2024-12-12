using Pogoda.Views.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Pogoda.ViewModels
{
    public partial class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand HomeCommand { get; }

        private HomeViewViewModel _homeViewViewModel;
        public HomeViewViewModel _HomeViewViewModel
        {
            get { return _homeViewViewModel; }
            set
            {
                _homeViewViewModel = value;
                OnPropertyCanged();
            }
        }
        public MainWindowViewModel()
        {
            HomeCommand = new RelayCommand(OpenHomeView , CanOpenHomeView);
        }

        private void OpenHomeView(object obj)
        {
            _HomeViewViewModel = new HomeViewViewModel();
        }
        private bool CanOpenHomeView(object arg)
        {
            return true;
        }
        public void OnPropertyCanged([CallerMemberName] string prop = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
