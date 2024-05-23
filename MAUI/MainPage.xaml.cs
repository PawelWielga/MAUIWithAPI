namespace MAUI
{
    public partial class MainPage : ContentPage
    {
        public MainPage(APIHostedService x)
        {
            InitializeComponent();

            x.StartAsync(CancellationToken.None);
        }
    }
}
