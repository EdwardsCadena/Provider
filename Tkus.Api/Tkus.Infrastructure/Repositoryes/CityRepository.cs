using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tkus.Core.Entities;
using Tkus.Core.Interfaces;
using Tkus.Infrastructure.Data;

namespace Tkus.Infrastructure.Repositoryes
{
    public class CityRepository : ICityRepository
    {
        private readonly TkosContext _context;
        //private readonly HttpClient _httpClient;
        public CityRepository(TkosContext context/*, HttpClient httpClient*/)
        {
            _context = context;
            //_httpClient = httpClient;
        }
        public async Task<IEnumerable<City>> GetCities()
        {
            var city = await _context.Cities.ToListAsync();
            return city;
        }


        //public async Task ApiExtern()
        //{
        //    // Realizar solicitud a la API de países
        //    var response = await _httpClient.GetAsync("https://restcountries.com/v3.1/all");
        //    var countries = await response.Content.ReadAsAsync<List<City>>();

        //    // Conectarse a la base de datos y guardar los nombres de las ciudades
        //    using (var connection = new SqlConnection("Server=EDWARD; Database=Tkos; TrustServerCertificate=True; Encrypt=False; Trusted_Connection=True"))
        //    {
        //        connection.Open();

        //        foreach (var country in countries)
        //        {
        //            foreach (var city in country.Cities)
        //            {
        //                using (var command = new SqlCommand())
        //                {
        //                    command.Connection = connection;
        //                    command.CommandText = "INSERT INTO Cities (Name) VALUES (@name)";
        //                    command.Parameters.AddWithValue("@name", city.Name);
        //                    command.ExecuteNonQuery();
        //                }
        //            }
        //        }
        //    }
        //} 
    }
}
