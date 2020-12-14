using System;
using WeightLiftingCalculator.ViewModels;
using Xamarin.Forms;

namespace WeightLiftingCalculator.Views
{
    public partial class HomePage : ContentPage
    {
        public static string Day { get; set; }
        public static double percent70 { get; set; }
        public static double side70 { get; set; }
        public static double plates70 { get; set; }
        public static double percent72 { get; set; }
        public static double side72 { get; set; }
        public static double plates72 { get; set; }
        public static double percent75 { get; set; }
        public static double side75 { get; set; }
        public static double plates75 { get; set; }
        public static double percent77 { get; set; }
        public static double side77 { get; set; }
        public static double plates77 { get; set; }
        public static double percent80 { get; set; }
        public static double side80 { get; set; }
        public static double plates80 { get; set; }
        public static double percent82 { get; set; }
        public static double side82 { get; set; }
        public static double plates82 { get; set; }
        public static double percent85 { get; set; }
        public static double side85 { get; set; }
        public static double plates85 { get; set; }
        public static double percent87 { get; set; }
        public static double side87 { get; set; }
        public static double plates87 { get; set; }
        public static double percent90 { get; set; }
        public static double side90 { get; set; }
        public static double plates90 { get; set; }
        public static double percent92 { get; set; }
        public static double side92 { get; set; }
        public static double plates92 { get; set; }
        public static double percent95 { get; set; }
        public static double side95 { get; set; }
        public static double plates95 { get; set; }
        public static double percent97 { get; set; }
        public static double side97 { get; set; }
        public static double plates97 { get; set; }
        public static double percent100 { get; set; }
        public static double side100 { get; set; }
        public static double plates100 { get; set; }
        public static double percent105 { get; set; }
        public static double side105 { get; set; }
        public static double plates105 { get; set; }
        public static double percent110 { get; set; }
        public static double side110 { get; set; }
        public static double plates110 { get; set; }
        public static int themeMode { get; set; }
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
            themeMode = 0;
        }

        async void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            double weight = Convert.ToDouble(text);
            double plates;
            percent70 = weight * .7;
            side70 = sideWeight(percent70, out plates);
            plates70 = plates;
            percent72 = weight * .725;
            side72 = sideWeight(percent72, out plates);
            plates72 = plates;
            percent75 = weight * .75;
            side75 = sideWeight(percent75, out plates);
            plates75 = plates;
            percent77 = weight * .775;
            side77 = sideWeight(percent77, out plates);
            plates77 = plates;
            percent80 = weight * .8;
            side80 = sideWeight(percent80, out plates);
            plates80 = plates;
            percent82 = weight * .825;
            side82 = sideWeight(percent82, out plates);
            plates82 = plates;
            percent85 = weight * .85;
            side85 = sideWeight(percent85, out plates);
            plates85 = plates;
            percent87 = weight * .875;
            side87 = sideWeight(percent87, out plates);
            plates87 = plates;
            percent90 = weight * .9;
            side90 = sideWeight(percent90, out plates);
            plates90 = plates;
            percent92 = weight * .925;
            side92 = sideWeight(percent92, out plates);
            plates92 = plates;
            percent95 = weight * .95;
            side95 = sideWeight(percent95, out plates);
            plates95 = plates;
            percent97 = weight * .975;
            side97 = sideWeight(percent97, out plates);
            plates97 = plates;
            percent100 = weight;
            side100 = sideWeight(percent100, out plates);
            plates100 = plates;
            percent105 = weight * 1.05;
            side105 = sideWeight(percent105, out plates);
            plates105 = plates;
            percent110 = weight * 1.1;
            side110 = sideWeight(percent110, out plates);
            plates110 = plates;
            if (Day == "Tuesday")
            {
                await Shell.Current.GoToAsync(nameof(TuesdayPage));
            }
            else if (Day == "Wednesday")
            {
                await Shell.Current.GoToAsync(nameof(WednesdayPage));
            }
            else if (Day == "Friday")
            {
                await Shell.Current.GoToAsync(nameof(FridayPage));
            }
            else if (Day == "Saturday")
            {
                await Shell.Current.GoToAsync(nameof(SaturdayPage));
            }
            else
            {
                await DisplayAlert("Rip", "Choose a day homie!", "Retry");
            }
        }

        double sideWeight(double weight, out double plates)
        {
            double sideWeight = 0.0;
            if (weight > 765)
            {
                plates = 8;
                sideWeight = (weight - 765) / 2;
            }
            else if (weight > 675)
            {
                plates = 7;
                sideWeight = (weight - 675) / 2;
            }
            else if (weight > 585)
            {
                plates = 6;
                sideWeight = (weight - 585) / 2;

            }
            else if (weight > 495)
            {
                plates = 5;
                sideWeight = (weight - 495) / 2;
            }
            else if (weight > 405)
            {
                plates = 4;
                sideWeight = (weight - 405) / 2;
            }
            else if (weight > 315)
            {
                plates = 3;
                sideWeight = (weight - 315) / 2;
            }
            else if (weight > 225)
            {
                plates = 2;
                sideWeight = (weight - 225) / 2;
            }
            else if (weight > 135)
            {
                plates = 1;
                sideWeight = (weight - 135) / 2;
            }
            else
            {
                plates = 0;
                sideWeight = (weight - 45) / 2;
            }

            return sideWeight;
        }

        void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = DayPicker.SelectedIndex;

            if (selectedIndex != -1)
            {
                Day = Convert.ToString(DayPicker.ItemsSource[selectedIndex]);
            }
        }

        void OnThemeButtonChange(object sender, EventArgs e)
        {
            themeMode++;
            if (themeMode % 2 == 0)
            {
                Application.Current.UserAppTheme = OSAppTheme.Light;
            }
            else
            {
                Application.Current.UserAppTheme = OSAppTheme.Dark;
            }

        }
    }
}