using System;
using System.Collections.Generic;
using Lab2.ViewModels;

using Xamarin.Forms;

namespace Lab2.Views
{
    public partial class ListaEstudiantesView : ContentPage
    {
        public ListaEstudiantesView()
        {
            InitializeComponent();
            BindingContext = EstudianteViewModel.GetInstance();
        }
    }
}
