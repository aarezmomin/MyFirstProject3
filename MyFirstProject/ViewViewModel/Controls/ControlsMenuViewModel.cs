using MyFirstProject.Models;
using MyFirstProject.ViewViewModel.Controls.Slider;
using MyFirstProject.ViewViewModel.Controls.Stepper;
using MyFirstProject.ViewViewModel.Controls.Switch;
using MyFirstProject.ViewViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MyFirstProject.ViewViewModel.Controls
{
    public class ControlsMenuViewModel : BaseViewModel
    {
        public ICommand OnSliderViewClicked { get; set; }
        public ICommand OnSteppersViewClicked { get; set; }

        public ICommand OnSwitchViewClicked { get; set; }

        public ControlsMenuViewModel()
        {
            Title = Titles.ListViewTitle;
            OnSliderViewClicked = new Command(OnSliderViewClickedAsync);
            OnSteppersViewClicked = new Command(OnSteppersViewClickedAsync);

            OnSwitchViewClicked = new Command(OnSwitchViewClickedAsync);
        }
        private async void OnSliderViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SliderView());
        }
        private async void OnSteppersViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SteppersView());
        }

        private async void OnSwitchViewClickedAsync(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SwitchView());
        }
    }
}