using AGB_App.Messages;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AGB_App.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _name = string.Empty;
        private string _password = string.Empty;
        private RelayCommand _loginCommand = null;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value) return;
                _name = value;
                RaisePropertyChanged(() => Name);
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (_password == value) return;
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        public ICommand LoginCommand
        {
            get
            {
                if(_loginCommand == null)
                {
                    _loginCommand = new RelayCommand(() => Login());
                }
                return _loginCommand;
            }
        }

        private void Login()
        {
            Messenger.Default.Send(new OpenMainPageMessage());
        }
    }
}
