using System.Text.Json;

namespace RestCountriesAPI
{
    public class CountryService
    {
        private readonly HttpClient _httpClient = new HttpClient();

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            string url = "https://restcountries.com/v3.1/all";
            var response = await _httpClient.GetStringAsync(url);


            // Configuramos las opciones del serializador JSON
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };


            // Deserializamos la respuesta JSON a una lista de objetos Country
            return JsonSerializer.Deserialize<List<Country>>(response, options);
        }
    }
}
