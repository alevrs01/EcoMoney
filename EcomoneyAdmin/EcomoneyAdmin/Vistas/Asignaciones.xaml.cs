﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EcomoneyAdmin.VistaModelo;

namespace EcomoneyAdmin.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Asignaciones : ContentPage
    {
        public Asignaciones()
        {
            InitializeComponent();
            BindingContext = new VMasignaciones(Navigation);
        }
    }
}