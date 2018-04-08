using System;
using System.Collections.Generic;
using Lab2.Models;
using Lab2.ViewModels;
using Lab2.Views;

using Xamarin.Forms;

namespace Lab2.Views
{
    public partial class TabPagesControlView : TabbedPage
    {
        public TabPagesControlView()
        {
            InitializeComponent();
            BindingContext = EstudianteViewModel.GetInstance();
        }
    }
}
