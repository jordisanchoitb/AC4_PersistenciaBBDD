using Microsoft.Extensions.Configuration;
using Npgsql;
using AC4_PersistenciaBBDD.DTOs;

namespace AC4_PersistenciaBBDD.Persistence.Utils
{
    public class NpgsqlUtils
    {
        public static string OpenConnection()
        {
            // Carregar la cadena de connexió a la base de dades des de l'arxiu de configuració
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile(@"appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            return config.GetConnectionString("MyPostgresConn");
        }

        public static ComarcaDTO GetContact(NpgsqlDataReader reader)
        {
            ComarcaDTO c = new ComarcaDTO
            {
                Any = reader.GetInt32(0),
                CodiComarca = reader.GetInt32(1),
                NomComarca = reader.GetString(2),
                Poblacio = reader.GetInt32(3),
                DomesticXarxa = reader.GetDouble(4),
                ActivitatsEconomiques = reader.GetDouble(5),
                Total = reader.GetDouble(6),
                ConsumDomesticPerCapita = reader.GetDouble(7)
            };
            return c;
        }
    }
}
