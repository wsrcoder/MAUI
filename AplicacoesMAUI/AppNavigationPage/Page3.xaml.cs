namespace AppNavigationPage;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private void OnPreviousPage(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}