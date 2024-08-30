using Microsoft.Maui.Controls;

namespace AppCitasMedicas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            
            string usuario = UserEntry.Text;
            string contraseña = PasswordEntry.Text;
            string tipoDocumento = DocumentTypePicker.SelectedItem?.ToString();

            
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                
                await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
            }
            else
            {
                
                await DisplayAlert("Éxito", $"Usuario: {usuario}\nTipo de documento: {tipoDocumento}", "OK");

                await Navigation.PushAsync(new MenuPage());
            }
        }
    }
}
