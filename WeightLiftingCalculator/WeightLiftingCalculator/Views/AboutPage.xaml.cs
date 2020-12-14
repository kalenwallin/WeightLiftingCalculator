using WeightLiftingCalculator.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WeightLiftingCalculator.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            this.BindingContext = new AboutViewModel();

            // Created By: Kalen Wallin
            var createdBy = new FormattedString();
            createdBy.Spans.Add(new Span { Text = "Created By: ", FontSize = 32 });
            createdBy.Spans.Add(new Span { Text = "Kalen Wallin", TextColor = Color.FromHex("#2196F3"), FontSize = 32 });
            

            Content = new StackLayout
            {
                Margin = new Thickness(20),
                Children =
            {
                new Label { FormattedText = createdBy },
                new Label { Text = "I created this app to assist me while I workout. On Tuesday, Wednesday, Friday, and Saturday, the workout I do requires me to lift my 3 rep max at a certain percentage.", FontSize = 20},
                new Label { Text = "For Example, On fridays I do 5 reps at 90%, 4 reps at 95%, 3 reps at 100%, 2 reps at 105%, and 1 rep at 110%", TextColor = Color.FromHex("#2196F3"), FontSize = 20 },
                new Label { Text = "I do these calculations on my phone's calculator app before every set. I have 5 exercises and 5 sets of each exercise, so each workout I am making 25 calculations.", FontSize = 20 },
                new Label { Text = "So instead of doing all those calculations I can now use this app to insert my 3 rep max and day of week once rather than 5 times per exercise. ", FontSize = 20 },

            }
            };
        }
    }
}