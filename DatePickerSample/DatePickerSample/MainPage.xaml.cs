﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DatePickerSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void PickerButton_Clicked(object sender, System.EventArgs e)
        {
            datePicker.IsOpen = true;
        }
    }
}
