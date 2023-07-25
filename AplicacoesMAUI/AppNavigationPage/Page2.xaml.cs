namespace AppNavigationPage;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private void OnPreviousPage(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
    private void OnNextPage(object sender, EventArgs e)
    {
		Navigation.PushAsync(new Page3());
    }
}