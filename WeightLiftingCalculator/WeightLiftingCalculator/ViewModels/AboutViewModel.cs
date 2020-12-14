using Xamarin.Forms;

namespace WeightLiftingCalculator.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public AboutViewModel()
        {
            Title = "About";
        }
    }
}
