namespace AppFlyOutPage;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void OnChangeToPage1(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new Page1();
    }

    private void OnChangeToPage2(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new Page2();
    }

    private void OnChangeToPage3(object sender, EventArgs e)
    {
        ((FlyoutPage)App.Current.MainPage).Detail = new Page3();
    }
}