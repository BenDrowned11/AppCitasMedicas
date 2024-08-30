using Microsoft.Maui.Controls;

namespace AppCitasMedicas
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new NavigationPage(new MainPage());
        }
    }
}
