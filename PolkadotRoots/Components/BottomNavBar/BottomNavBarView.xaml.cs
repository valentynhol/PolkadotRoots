namespace PolkadotRoots.Components.BottomNavBar;

public partial class BottomNavBarView : ContentView
{
	public BottomNavBarView()
	{
		InitializeComponent();

		BindingContext = DependencyService.Get<BottomNavBarViewModel>();
    }
}