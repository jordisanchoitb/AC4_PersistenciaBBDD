using AC4_PersistenciaBBDD.DTOs;
using AC4_PersistenciaBBDD.Persistence.DAO;
using AC4_PersistenciaBBDD.Persistence.Utils;
using Npgsql;

namespace AC4_PersistenciaBBDD.Persistence.Mapping
{
    public class ComarcaDAO : IComarcaDAO
    {
        private readonly string connectionString;

        public ComarcaDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddComarca(ComarcaDTO comarca)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "INSERT INTO \"comarca\" (\"anycomarca\", \"codicomarca\", \"comarca\", \"poblacio\", \"domesticxarxa\", \"acteconomiques\", \"total\", \"consumdomestic\") VALUES (@Any, @CodiComarca, @NomComarca, @Poblacio, @DomesticXarxa, @ActivitatsEconomiques, @Total, @ConsumDomesticPerCapita)";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Any", comarca.Any);
                command.Parameters.AddWithValue("@CodiComarca", comarca.CodiComarca);
                command.Parameters.AddWithValue("@NomComarca", comarca.NomComarca);
                command.Parameters.AddWithValue("@Poblacio", comarca.Poblacio);
                command.Parameters.AddWithValue("@DomesticXarxa", comarca.DomesticXarxa);
                command.Parameters.AddWithValue("@ActivitatsEconomiques", comarca.ActivitatsEconomiques);
                command.Parameters.AddWithValue("@Total", comarca.Total);
                command.Parameters.AddWithValue("@ConsumDomesticPerCapita", comarca.ConsumDomesticPerCapita);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void DeleteComarca(int id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "DELETE FROM \"comarca\" WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<ComarcaDTO> GetAllComarca()
        {
            List<ComarcaDTO> contacts = new List<ComarcaDTO>();

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"anycomarca\", \"codicomarca\", \"comarca\", \"poblacio\", \"domesticxarxa\", \"acteconomiques\", \"total\", \"consumdomestic\" FROM \"comarca\"";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // ORM: [--,--,--] -----> ContactDTO                  
                    ComarcaDTO contact = NpgsqlUtils.GetContact(reader);
                    contacts.Add(contact);
                }
            }
            return contacts;

        }

        public ComarcaDTO GetComarcaById(int id)
        {
            ComarcaDTO contact = null;

            using (NpgsqlConnection connection = new NpgsqlConnection(NpgsqlUtils.OpenConnection()))
            {
                string query = "SELECT \"anycomarca\", \"codicomarca\", \"comarca\", \"poblacio\", \"domesticxarxa\", \"acteconomiques\", \"total\", \"consumdomestic\" FROM \"comarca\" WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                connection.Open();
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    // ORM: [--,--,--] -----> ComarcaDTO
                    contact = NpgsqlUtils.GetContact(reader);
                }
            }

            return contact;

        }

        public void UpdateComarca(ComarcaDTO comarca)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string query = "UPDATE \"comarca\" SET \"anycomarca\" = @Any, \"codicomarca\" = @CodiComarca, \"comarca\" = @NomComarca, \"poblacio\" = @Poblacio, \"domesticxarxa\" = @DomesticXarxa, \"acteconomiques\" = @ActivitatsEconomiques, \"total\" = @Total, \"consumdomestic\" = @ConsumDomesticPerCapita WHERE \"ID\" = @Id";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("@Any", comarca.Any);
                command.Parameters.AddWithValue("@CodiComarca", comarca.CodiComarca);
                command.Parameters.AddWithValue("@NomComarca", comarca.NomComarca);
                command.Parameters.AddWithValue("@Poblacio", comarca.Poblacio);
                command.Parameters.AddWithValue("@DomesticXarxa", comarca.DomesticXarxa);
                command.Parameters.AddWithValue("@ActivitatsEconomiques", comarca.ActivitatsEconomiques);
                command.Parameters.AddWithValue("@Total", comarca.Total);
                command.Parameters.AddWithValue("@ConsumDomesticPerCapita", comarca.ConsumDomesticPerCapita);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }
}