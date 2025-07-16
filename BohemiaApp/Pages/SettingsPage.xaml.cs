using PlutoFramework.Templates.PageTemplate;

namespace BohemiaApp.Pages;

public partial class SettingsPage : PageTemplate
{
	public SettingsPage()
	{
		InitializeComponent();

		BindingContext = new SettingsPageViewModel();
    }
}