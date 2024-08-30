using Microsoft.Maui.Controls;
using System;

namespace AppCitasMedicas
{
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage()
        {
            InitializeComponent();
        }

        private async void OnConfirmReservationClicked(object sender, EventArgs e)
        {
            string date = DateEntry.Text;
            string specialty = SpecialtyPicker.SelectedItem?.ToString();
            string doctor = DoctorPicker.SelectedItem?.ToString();

            if (date.Length == 6 && int.TryParse(date, out _))
            {
                string formattedDate = $"{date.Substring(0, 2)}/{date.Substring(2, 2)}/{date.Substring(4, 2)}";

                await Navigation.PushAsync(new Confirmacion(formattedDate, specialty, doctor));
            }
            else
            {
                await DisplayAlert("Error", "Por favor, ingrese una fecha válida en formato ddMMyy.", "OK");
            }
        }
    }
}
