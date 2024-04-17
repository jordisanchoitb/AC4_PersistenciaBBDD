using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC4_PersistenciaBBDD
{
    public class CSVHandler
    {
        public static string? PATH { get; set; }

        public CSVHandler(string path)
        {
            PATH = path;
        }

        public List<Comarca> ReadAllCsv()
        {
            using var reader = new StreamReader(PATH);
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            return csv.GetRecords<Comarca>().ToList();
        }

        public void AppendCsv(List<Comarca> comarques)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };
            using var stream = File.Open(PATH, FileMode.Append);
            using var writer = new StreamWriter(stream);
            using var csv = new CsvWriter(writer, config);
            csv.WriteRecords(comarques);
        }
    }
}
