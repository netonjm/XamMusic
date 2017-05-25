﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamMusic.ViewModels;

namespace XamMusic.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrevControl : ContentView
    {
        public PrevControl()
        {
            this.BindingContext = MusicStateViewModel.Instance;
            InitializeComponent();
        }
    }
}