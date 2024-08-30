using Microsoft.Maui.Controls;

namespace AppCitasMedicas
{
    public partial class Cancelada : ContentPage
    {
        public Cancelada()
        {
            InitializeComponent();
        }

        private async void OnAcceptClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
