using MyFirstProject.Models;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Entry.Entry1
{ 
    class Entry1ViewModel : BaseViewModel
    {
        public ICommand OnEntry1Clicked { get; }

        private string _entryText = string.Empty;

        public Entry1ViewModel()
        {
            Title = Titles.EntryTitle;
            OnEntry1Clicked = new Command(OnEntry1ClickedAsync);
        }

        public string Entry1Text
        {
            get { return _entryText; }

            set
            {
                if (_entryText != value)
                    SetProperty(ref _entryText, value);
            }
        }
        public async void OnEntry1ClickedAsync(object obj)
        {
            if (string.IsNullOrEmpty(_entryText.Trim()))
            {
                await Application.Current.MainPage.DisplayAlert(Titles.EntryTitle, "Entry can't be empty", "ok");
                return;
            }
        }
    }
}