namespace MauiTemplate.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnShowDemoClicked(object sender, EventArgs e)
	{
        IconDemo.IsVisible = true;
    }
}

