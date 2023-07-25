namespace AppFlyOutPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new FlyoutPageMenu();
        }
    }
}