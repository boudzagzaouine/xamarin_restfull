using RestFul.services;
using Xamarin.Forms;

namespace RestFul
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            DependencyService.Register<IPlaceService, PlaceServiceImpl>();
            MainPage =new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
