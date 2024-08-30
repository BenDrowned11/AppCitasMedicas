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
            DoctorLabel.Text = $"M�dico(a): {doctor}";
        }

        private async void OnAcceptClicked(object sender, EventArgs e)
        {
            
            await DisplayAlert("Confirmaci�n", "Cita aceptada con �xito.", "OK");

           
            await Navigation.PushAsync(new MenuPage());
        }

        private async void OnCancelClicked(object sender, EventArgs e)
        {
            var confirm = await DisplayAlert("Confirmar Cancelaci�n", "�Est�s seguro de que deseas cancelar esta cita?", "S�", "No");
            if (confirm)
            {
               
                await Navigation.PushAsync(new Cancelada());
            }
        }
    }
}
