using Microcharts;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MEntry = Microcharts.Entry;

namespace SmartHomeApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            DrawHumidlityLine();
        }

        private void DrawHumidlityLine()
        {
            var lineColor = SKColor.Parse("#EC7850");
            var entries = new[]
             {
                //new MEntry(30) {Color = lineColor},
                //new MEntry(45) {Color = lineColor},
                //new MEntry(40) {Color = lineColor},
                //new MEntry(50) {Color = lineColor},
                //new MEntry(60) {Color = lineColor},
                //new MEntry(72) {Color = lineColor},
                //new MEntry(65) {Color = lineColor},
                //new MEntry(80) {Color = lineColor},

                new MEntry(0) {Color = lineColor},
                new MEntry(40) {Color = lineColor},
                new MEntry(20) {Color = lineColor},
                new MEntry(65) {Color = lineColor},
                new MEntry(55) {Color = lineColor},
            };

            var chart = new LineChart() 
             { 
                Entries = entries, 
                BackgroundColor = Color.Transparent.ToSKColor(), 
                LineSize = 10, 
                LineAreaAlpha = 0 
            };

            chartView.Chart = chart;
        }

        private void AirConSelected_Tapped(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AirConPage());
        }
    }
}
