﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyFirstProject.ViewViewModel.Controls.Entry.Entry1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Entry1View : ContentPage
    {
        public Entry1View()
        {
            InitializeComponent();

            BindingContext = new Entry1ViewModel();
        }
    }
}