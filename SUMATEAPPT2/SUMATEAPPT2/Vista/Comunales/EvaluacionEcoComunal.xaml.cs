﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SUMATEAPPT2.Vista.Comunales
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EvaluacionEcoComunal : ContentPage
    {
        public EvaluacionEcoComunal()
        {
            InitializeComponent();
        }

        private async void btnEmprendedor_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EvEcoClienteEmprendedor( ));
        }

        private async void btnEvaluacion_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EvEcoComunal( ));
        }
    }
}