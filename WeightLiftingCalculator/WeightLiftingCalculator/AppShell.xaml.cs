using WeightLiftingCalculator.Views;
using Xamarin.Forms;

namespace WeightLiftingCalculator
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(TuesdayPage), typeof(TuesdayPage));
            Routing.RegisterRoute(nameof(WednesdayPage), typeof(WednesdayPage));
            Routing.RegisterRoute(nameof(FridayPage), typeof(FridayPage));
            Routing.RegisterRoute(nameof(SaturdayPage), typeof(SaturdayPage));
        }

    }
}
