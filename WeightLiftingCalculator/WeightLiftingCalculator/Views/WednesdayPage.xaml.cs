using System;
using WeightLiftingCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightLiftingCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WednesdayPage : ContentPage
    {
        public WednesdayPage()
        {
            InitializeComponent();
            this.BindingContext = new WednesdayViewModel();
            Title = "Wednesday";

            //Percent 72.5 string
            var percent725format = new FormattedString();
            percent725format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent72), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent725format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent725format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent725format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent725format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates72), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent725format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent725format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side72), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent725format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 77.5 String
            var percent775format = new FormattedString();
            percent775format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent77), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent775format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent775format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent775format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent775format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates77), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent775format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent775format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side77), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent775format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 82.5 String
            var percent825format = new FormattedString();
            percent825format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent82), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent825format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent825format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent825format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent825format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates82), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent825format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent825format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side82), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent825format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 87.5 String
            var percent875format = new FormattedString();
            percent875format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent87), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent875format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent875format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent875format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent875format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates87), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent875format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent875format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side87), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent875format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 92.5 String
            var percent925format = new FormattedString();
            percent925format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent92), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent925format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent925format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent925format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent925format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates92), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent925format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent925format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side92), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent925format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });


            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
            {
                new Label { Text = "72.5%", FontSize = 35 },
                new Label { FormattedText = percent725format },
                new Label { Text = "77.5%", FontSize = 35 },
                new Label { FormattedText = percent775format },
                new Label { Text = "82.5%", FontSize = 35 },
                new Label { FormattedText = percent825format },
                new Label { Text = "87.5%", FontSize = 35 },
                new Label { FormattedText = percent875format },
                new Label { Text = "92.5%", FontSize = 35 },
                new Label { FormattedText = percent925format },
            }
            };
        }
    }
}