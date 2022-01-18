using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls.Entry.Entry1;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls.Entry
{
    class EntryControlsViewModel : BaseViewModel
    {
        public ICommand OnEntry1ViewClicked { get; set; }

        public EntryControlsViewModel()
        {
            Title = Titles.ListViewTitle;
            OnEntry1ViewClicked = new Command(OnEntry1ViewClickedAsync);
        }
        private async void OnEntry1ViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new Entry1View());
        }
    }
}
