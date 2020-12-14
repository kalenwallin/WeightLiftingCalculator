using System;
using WeightLiftingCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightLiftingCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FridayPage : ContentPage
    {
        public FridayPage()
        {
            InitializeComponent();
            this.BindingContext = new FridayViewModel();
            Title = "Friday";

            //Percent 90 string
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

            //Percent 105 String
            var percent105format = new FormattedString();
            percent105format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent105), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent105format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent105format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent105format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent105format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates105), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent105format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent105format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side105), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent105format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });

            //Percent 110 String
            var percent110format = new FormattedString();
            percent110format.Spans.Add(new Span { Text = Convert.ToString(HomePage.percent110), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent110format.Spans.Add(new Span { Text = ", ", FontSize = 20 });
            percent110format.Spans.Add(new Span { Text = "Plates:", FontSize = 20 });
            percent110format.Spans.Add(new Span { Text = " ", FontSize = 20 });
            percent110format.Spans.Add(new Span { Text = Convert.ToString(HomePage.plates110), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent110format.Spans.Add(new Span { Text = " + ", FontSize = 20 });
            percent110format.Spans.Add(new Span { Text = Convert.ToString(HomePage.side110), FontSize = 20, TextColor = Color.FromHex("#2196F3") });
            percent110format.Spans.Add(new Span { Text = " lbs\n", FontSize = 20 });


            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
            {
                new Label { Text = "90%", FontSize = 35 },
                new Label { FormattedText = percent90format },
                new Label { Text = "95%", FontSize = 35 },
                new Label { FormattedText = percent95format },
                new Label { Text = "100%", FontSize = 35 },
                new Label { FormattedText = percent100format },
                new Label { Text = "105%", FontSize = 35 },
                new Label { FormattedText = percent105format },
                new Label { Text = "110%", FontSize = 35 },
                new Label { FormattedText = percent110format },
            }
            };
        }
    }
}