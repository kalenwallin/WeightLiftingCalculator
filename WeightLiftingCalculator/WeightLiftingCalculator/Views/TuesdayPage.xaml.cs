using System;
using WeightLiftingCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace WeightLiftingCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TuesdayPage : ContentPage
    {
        public TuesdayPage()
        {
            InitializeComponent();
            this.BindingContext = new TuesdayViewModel();
            Title = "Tuesday";

            //Percent 80 string
            var percent80format = new FormattedString();
            percent80format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent80), FontSize = 20, TextColor = Color.FromHex("#2196F3")});
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

            //Percent 95 String
            var percent95format = new FormattedString();
            percent95format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent95), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent95format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent95format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent95format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent95format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates95), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent95format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent95format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side95), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent95format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 100 String
            var percent100format = new FormattedString();
            percent100format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent100), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent100format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent100format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent100format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent100format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates100), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent100format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent100format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side100), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent100format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });


            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
            {
                new Label { Text = "80%", FontSize = 35 },
                new Label { FormattedText = percent80format },
                new Label { Text = "85%", FontSize = 35 },
                new Label { FormattedText = percent85format },
                new Label { Text = "90%", FontSize = 35 },
                new Label { FormattedText = percent90format },
                new Label { Text = "95%", FontSize = 35 },
                new Label { FormattedText = percent95format },
                new Label { Text = "100%", FontSize = 35 },
                new Label { FormattedText = percent100format },
            }
            };
        }
    }
}