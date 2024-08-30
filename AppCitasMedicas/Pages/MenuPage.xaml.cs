using Microsoft.Maui.Controls;

namespace AppCitasMedicas
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OnReserveAppointmentClicked(object sender, EventArgs e)
        {
            
            await Navigation.PushAsync(new ReservationPage());
        }

        private void OnConsultAppointmentClicked(object sender, EventArgs e)
        {
            
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            
            await Navigation.PopToRootAsync();
        }
    }
}
