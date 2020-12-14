using System;
using WeightLiftingCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightLiftingCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SaturdayPage : ContentPage
    {
        public SaturdayPage()
        {
            InitializeComponent();
            this.BindingContext = new SaturdayViewModel();
            Title = "Saturday";

            //Percent 70 string
            var percent70format = new FormattedString();
            percent70format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent70), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent70format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent70format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent70format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent70format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates70), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent70format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent70format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side70), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent70format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 75 String
            var percent75format = new FormattedString();
            percent75format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent75), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent75format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent75format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent75format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent75format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates75), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent75format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent75format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side75), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent75format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 80 String
            var percent80format = new FormattedString();
            percent80format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent80), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent80format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent80format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent80format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent80format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates80), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent80format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent80format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side80), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent80format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 85 String
            var percent85format = new FormattedString();
            percent85format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent85), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent85format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent85format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent85format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent85format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates85), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent85format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent85format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side85), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent85format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 90 String
            var percent90format = new FormattedString();
            percent90format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent90), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent90format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent90format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent90format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent90format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates90), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent90format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent90format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side90), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent90format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });


            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
            {
                new Label { Text = "70%", FontSize = 35 },
                new Label { FormattedText = percent70format },
                new Label { Text = "75%", FontSize = 35 },
                new Label { FormattedText = percent75format },
                new Label { Text = "80%", FontSize = 35 },
                new Label { FormattedText = percent80format },
                new Label { Text = "85%", FontSize = 35 },
                new Label { FormattedText = percent85format },
                new Label { Text = "90%", FontSize = 35 },
                new Label { FormattedText = percent90format },
            }
            };
        }
    }
}