using RestCountriesAPI;

internal class Program
{
    static async Task Main(string[] args)
    {



        //Mensaje para preguntar cuantos paises desea ver
        Console.WriteLine("¿Cuántos países desea ver? (Máximo 100)");
        //Leemos la respuesta del usuario
        string? respuesta = Console.ReadLine();
        //Validamos la respuesta
        if (respuesta == null || !int.TryParse(respuesta, out int cantidad) || cantidad < 1 || cantidad > 100)
        {
            Console.WriteLine("Respuesta no válida. Se mostrarán 100 países.");
            cantidad = 100;
        }

        // Convertimos la respuesta a un número entero
        int respuestaInt = int.Parse(respuesta);

        var service = new CountryService();
        var countries = await service.GetAllCountriesAsync();

        foreach (var country in countries.Take(respuestaInt)) // Mostramos solo los primeros 10
        {
            Console.WriteLine($"País: {country.name.Common}");
            Console.WriteLine($"Capital: {(country.Capital != null ? string.Join(", ", country.Capital) : "No tiene")}");
            Console.WriteLine($"Región: {country.Region}");
            Console.WriteLine(new string('-', 40));
        }
    }
}
