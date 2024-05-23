namespace MAUI
{
    public partial class App : Application
    {
        public App(IServiceProvider provider)
        {
            InitializeComponent();

            var x = provider.GetService<APIHostedService>();

            MainPage = new MainPage(x);
        }
    }
}
