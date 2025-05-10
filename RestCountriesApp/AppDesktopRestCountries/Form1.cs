using RestCountriesAPI;
using System.Data;
using System.Text.Json;

namespace AppDesktopRestCountries
{
    public partial class Form1 : Form
    {

        private List<Country> _countries = new List<Country>();
        private readonly HttpClient _httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void cbPaises_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCountry = (Country)cbPaises.SelectedItem;

            if (selectedCountry != null)
            {
                lblNombre.Text = selectedCountry.NombreVisible;
                lblCapital.Text = selectedCountry.Capital.FirstOrDefault() ?? "Sin capital";
                pbBandera.ImageLocation = selectedCountry.Flags.Png;
            }

        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string url = "https://restcountries.com/v3.1/all";
            var response = await _httpClient.GetStringAsync(url);

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _countries = JsonSerializer.Deserialize<List<Country>>(response, options);

            // Ordenamos alfabéticamente
            _countries = _countries.OrderBy(c => c.name.Common).ToList();

            cbPaises.DataSource = _countries;
            cbPaises.DisplayMember = "NombreVisible";

        }


    }
}
