﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Timers;
using Xamarin.Essentials;

namespace HerbApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreenHerbSite : ContentPage
    {
        public GreenHerbSite()
        {
            InitializeComponent();
           
        }

        private void StartCountdown(object sender, EventArgs e)
        {
            progBarName.Progress = 0;
            progBarName.ProgressTo(1, 180000, Easing.Linear);
            SetTimer(180000);
        }

        
        private static void SetTimer(int ms)
        {
            Timer myTimer;
            myTimer = new System.Timers.Timer(ms);

            //OnTimeEvent gdy odliczanie dobiegnie konca
            myTimer.Elapsed += OnTimeEvent;
            myTimer.AutoReset = false;
            myTimer.Enabled = true;
        }

        private static void OnTimeEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("Uplynal czas");
            Vibration.Vibrate(2000);
        }
    }
}