using System;
using System.Collections.Generic;
using Lab2.ViewModels;

using Xamarin.Forms;

namespace Lab2.Views
{
    public partial class NuevoEstudianteView : ContentPage
    {
        public NuevoEstudianteView()
        {
            InitializeComponent();
            BindingContext = EstudianteViewModel.GetInstance();
        }
    }
}
