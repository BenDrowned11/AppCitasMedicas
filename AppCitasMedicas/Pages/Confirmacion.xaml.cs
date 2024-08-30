using Microsoft.Maui.Controls;

namespace AppCitasMedicas
{
    public partial class Confirmacion : ContentPage
    {
        public Confirmacion(string date, string specialty, string doctor)
        {
            InitializeComponent();

            DateLabel.Text = $"Fecha: {date}";
            SpecialtyLabel.Text = $"Especialidad: {specialty}";
            DoctorLabel.Text = $"Médico(a): {doctor}";
        }

        private async void OnAcceptClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Confirmación", "Cita aceptada con éxito.", "OK");

           
            await Navigation.PushAsync(new MenuPage());
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            var confirm = await DisplayAlert("Confirmar Cancelación", "¿Estás seguro de que deseas cancelar esta cita?", "Sí", "No");
            if (confirm)
            {
               
                await Navigation.PushAsync(new Cancelada());
            }
        }
    }
}
