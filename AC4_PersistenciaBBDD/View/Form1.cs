using System.Data;
using System.Xml.Linq;
using AC4_PersistenciaBBDD.DTOs;
using AC4_PersistenciaBBDD.Persistence.Utils;
using AC4_PersistenciaBBDD.Persistence.DAO;
using AC4_PersistenciaBBDD.Persistence.Mapping;

namespace AC4_PersistenciaBBDD
{
    public partial class Form1 : Form
    {
        public static string xmlPath = @"..\..\..\fitxers\Consumdeaigua.xml";
        public static string csvPath = @"..\..\..\fitxers\Consumdeaigua.csv";

        public static CSVHandler csvhandler = new CSVHandler(csvPath);
        public static XMLHandler xmlhandler = new XMLHandler(xmlPath);

        private int tamañoPagina = 10;
        private int paginaActual = 1;

        private List<int> Anys = new List<int>();
        private List<string> Comarques = new List<string>();
        private List<ComarcaDTO> comarquescsv;

        private IComarcaDAO comarcaDAO = new ComarcaDAO(NpgsqlUtils.OpenConnection());
        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        private void CreateAndUpdateXML()
        {
            List<ComarcaDTO> comarques = csvhandler.ReadAllCsv();
            xmlhandler.ConvertToXml(comarques);
        }

        private void bttonClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cmbBoxAny.Text = "";
            cmbBoxComarca.Text = "";
            txtBoxPoblacio.Text = "";
            txtBoxDomesticXarxa.Text = "";
            txtBoxActEconomiques.Text = "";
            txtBoxConsumDomestic.Text = "";
            txtBoxTotal.Text = "";
        }

        private void LoadData()
        {
            // Serveix perque abans de inicialitzar el form
            // Estiguin tots els arxius actualitzats/creats
            CreateAndUpdateXML();

            // Llegir dades desde la bbdd en cas de que no funcioni es llegiran las dades del csv   
            try
            {
                comarquescsv = comarcaDAO.GetAllComarca().ToList();
            }
            catch (Exception ex)
            {
                comarquescsv = csvhandler.ReadAllCsv();
            }

            // Amb aquestas lineas de codi pujem a la base de dades les dades del csv en cas de que no hi hagin dades a la base de dades
            /*foreach (var comarca in comarquescsv)
            {
                try
                {
                    comarcaDAO.AddComarca(comarca);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la comarca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }*/

            // Carregar dades
            MostraDadesEnElDataGridView();

            // Carregar anys
            var anyantic = comarquescsv.Min(x => x.Any);

            List<int> anys = new List<int>();
            for (int i = anyantic; i <= 2050; i++)
            {
                anys.Add(i);
            }
            Anys = anys;
            cmbBoxAny.DataSource = anys;
            cmbBoxAny.SelectedIndex = -1;

            // Carregar comarques
            XDocument xDocument = XDocument.Load(xmlPath);

            var comarques = (from comarca in xDocument.Descendants("Comarca")
                             orderby Convert.ToInt32(comarca.Element("Codi").Value)
                             select $"{comarca.Element("Nom").Value.ToUpper()}").Distinct();

            Comarques = comarques.ToList();
            cmbBoxComarca.DataSource = comarques.ToList();
            cmbBoxComarca.SelectedIndex = -1;

        }

        private void MostraDadesEnElDataGridView()
        {
            dgv_Comarcas.DataSource = ObtindreDadesPaginades();
            dgv_Comarcas.Columns[1].Visible = false;
            dgv_Comarcas.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Comarcas.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Comarcas.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv_Comarcas.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private List<ComarcaDTO> ObtindreDadesPaginades()
        {
            int indexInici = (paginaActual - 1) * tamañoPagina;
            int indexFinal = Math.Min(indexInici + tamañoPagina, comarquescsv.Count);

            return comarquescsv.GetRange(indexInici, indexFinal - indexInici);
        }

        private void bttonSave_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                int any = Convert.ToInt32(cmbBoxAny.Text);
                // Afegeixo +1 ja que el primer element del combo box es 0
                int codiComarca = Convert.ToInt32(cmbBoxComarca.SelectedIndex + 1);
                string nomComarca = cmbBoxComarca.Text;
                int poblacio = Convert.ToInt32(txtBoxPoblacio.Text);
                double domesticXarxa = Convert.ToDouble(txtBoxDomesticXarxa.Text);
                double activitatsEconomiques = Convert.ToDouble(txtBoxActEconomiques.Text);
                double consumDomesticPerCapita = Convert.ToDouble(txtBoxConsumDomestic.Text.Replace('.',','));
                double total = Convert.ToDouble(txtBoxTotal.Text);

                List<ComarcaDTO> comarques = new List<ComarcaDTO> {
                new ComarcaDTO
                {
                    Any = any,
                    CodiComarca = codiComarca,
                    NomComarca = nomComarca,
                    Poblacio = poblacio,
                    DomesticXarxa = domesticXarxa,
                    ActivitatsEconomiques = activitatsEconomiques,
                    ConsumDomesticPerCapita = consumDomesticPerCapita,
                    Total = total
                }};
                
                try
                {
                    comarcaDAO.AddComarca(comarques[0]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la comarca", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                csvhandler.AppendCsv(comarques);

                MessageBox.Show("Comarca guardada correctament", "Guardat correctament", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CreateAndUpdateXML();

                try
                {
                    comarquescsv = comarcaDAO.GetAllComarca().ToList();
                }
                catch (Exception ex)
                {
                    comarquescsv = csvhandler.ReadAllCsv();
                }

                MostraDadesEnElDataGridView();

                ClearForm();

            }
        }

        private void dgv_Comarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;

            if (n != -1)
            {
                DataGridViewRow row = dgv_Comarcas.Rows[n];
                string nomComarca = row.Cells[2].Value.ToString();
                int poblacio = Convert.ToInt32(row.Cells[3].Value);
                double consumDomesticPerCapita = Convert.ToDouble(row.Cells[7].Value);

                CalcStats(nomComarca, poblacio, consumDomesticPerCapita);
            }
        }

        private void CalcStats(string nomComarca, int poblacio, double consumDomesticPerCapita)
        {
            // Calcular poblacio te mes de 20000 habitants
            if (PoblacioGreaterThan20000(poblacio))
                lblPoblacioResult.Text = "Si";
            else
                lblPoblacioResult.Text = "No";

            // Calcular consum domestic mitja
            // Preguntar com el calculem
            XDocument xDocument = XDocument.Load(xmlPath);
            var comarcaMitja = (from comarca in xDocument.Descendants("Comarca")
                                where comarca.Element("Nom").Value == nomComarca
                                group comarca by comarca.Element("Nom").Value into g
                                select new
                                {
                                    NomComarca = g.Key,
                                    ConsumDomesticMitja = g.Average(x => double.Parse(x.Element("ConsumDomesticPerCapita").Value)),
                                }).FirstOrDefault();

            lblConsumDomesticMitjaResult.Text = $"{comarcaMitja.ConsumDomesticMitja:N0}";


            // Consum domestic per capita mes alt
            var comarcaAlt = (from comarca in xDocument.Descendants("Comarca")
                              where comarca.Element("Nom").Value == nomComarca
                              orderby Convert.ToDouble(comarca.Element("ConsumDomesticPerCapita").Value) descending
                              select comarca.Element("ConsumDomesticPerCapita").Value).FirstOrDefault();

            if (double.Parse(comarcaAlt) == consumDomesticPerCapita)
            {
                lblConsumDomesticAltResult.Text = "Si";
            }
            else
            {
                lblConsumDomesticAltResult.Text = "No";
            }


            // Consum domestic per capita mes baix
            var comarcaBaix = (from comarca in xDocument.Descendants("Comarca")
                               where comarca.Element("Nom").Value == nomComarca
                               orderby Convert.ToDouble(comarca.Element("ConsumDomesticPerCapita").Value)
                               select comarca.Element("ConsumDomesticPerCapita").Value).FirstOrDefault();

            if (double.Parse(comarcaBaix) == consumDomesticPerCapita)
            {
                lblConsumDomesticBaixResult.Text = "Si";
            }
            else
            {
                lblConsumDomesticBaixResult.Text = "No";
            }
        }

        private bool PoblacioGreaterThan20000(int poblacio)
        {
            return poblacio > 20000;
        }

        private void cmbBoxAny_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBoxAny.Text))
            {
                AnyProvider.SetError(cmbBoxAny, "El camp any no pot estar buit");
                e.Cancel = true;
            }
            else if (!Anys.Contains(Int32.Parse(cmbBoxAny.Text)))
            {
                AnyProvider.SetError(cmbBoxAny, "L'any no esta dins de les opcions");
                e.Cancel = true;
            } 
            else
            {
                AnyProvider.SetError(cmbBoxAny, "");
                e.Cancel = false;
            }
        }

        private void cmbBoxComarca_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBoxComarca.Text))
            {
                ComarcaProvider.SetError(cmbBoxComarca, "El camp comarca no pot estar buit");
                e.Cancel = true;
            }
            else if (!Comarques.Contains(cmbBoxComarca.Text))
            {
                ComarcaProvider.SetError(cmbBoxComarca, "La comarca no esta dins de les opcions");
                e.Cancel = true;
            }
            else
            {
                ComarcaProvider.SetError(cmbBoxComarca, "");
                e.Cancel = false;
            }
        }

        private void txtBoxPoblacio_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPoblacio.Text))
            {
                PoblacioProvider.SetError(txtBoxPoblacio, "El camp poblacio no pot estar buit");
                e.Cancel = true;
            }
            else if (!IsNumber(txtBoxPoblacio.Text))
            {
                PoblacioProvider.SetError(txtBoxPoblacio, "El camp poblacio no pot contenir lletres");
                e.Cancel = true;
            }
            else if (!IsGreaterAndEqualThanZero(txtBoxPoblacio.Text))
            {
                PoblacioProvider.SetError(txtBoxPoblacio, "El camp poblacio no pot ser negatiu");
                e.Cancel = true;
            }
            else
            {
                PoblacioProvider.SetError(txtBoxPoblacio, "");
                e.Cancel = false;
            }
        }

        private void txtBoxDomesticXarxa_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxDomesticXarxa.Text))
            {
                DomesticXarxaProvider.SetError(txtBoxDomesticXarxa, "El camp domestic xarxa no pot estar buit");
                e.Cancel = true;
            }
            else if (!IsNumber(txtBoxDomesticXarxa.Text))
            {
                DomesticXarxaProvider.SetError(txtBoxDomesticXarxa, "El camp domestic xarxa no pot contenir lletres");
                e.Cancel = true;
            }
            else if (!IsGreaterAndEqualThanZero(txtBoxDomesticXarxa.Text))
            {
                DomesticXarxaProvider.SetError(txtBoxDomesticXarxa, "El camp domestic xarxa no pot ser negatiu");
                e.Cancel = true;
            }
            else
            {
                DomesticXarxaProvider.SetError(txtBoxDomesticXarxa, "");
                e.Cancel = false;
            }
        }

        private void txtBoxActEconomiques_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxActEconomiques.Text))
            {
                ActEcoProvider.SetError(txtBoxActEconomiques, "El camp activitats economiques no pot estar buit");
                e.Cancel = true;
            }
            else if (!IsNumber(txtBoxActEconomiques.Text))
            {
                ActEcoProvider.SetError(txtBoxActEconomiques, "El camp activitats economiques no pot contenir lletres");
                e.Cancel = true;
            }
            else if (!IsGreaterAndEqualThanZero(txtBoxActEconomiques.Text))
            {
                ActEcoProvider.SetError(txtBoxActEconomiques, "El camp activitats economiques no pot ser negatiu");
                e.Cancel = true;
            }
            else
            {
                ActEcoProvider.SetError(txtBoxActEconomiques, "");
                e.Cancel = false;
            }
        }

        private void txtBoxConsumDomestic_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxConsumDomestic.Text))
            {
                ConsumDomesticProvider.SetError(txtBoxConsumDomestic, "El camp consum domestic no pot estar buit");
                e.Cancel = true;
            }
            else if (!IsNumber(txtBoxConsumDomestic.Text))
            {
                ConsumDomesticProvider.SetError(txtBoxConsumDomestic, "El camp consum domestic no pot contenir lletres");
                e.Cancel = true;
            }
            else if (!IsGreaterAndEqualThanZero(txtBoxConsumDomestic.Text))
            {
                ConsumDomesticProvider.SetError(txtBoxConsumDomestic, "El camp consum domestic no pot ser negatiu");
                e.Cancel = true;
            }
            else
            {
                ConsumDomesticProvider.SetError(txtBoxConsumDomestic, "");
                e.Cancel = false;
            }
        }

        private void txtBoxTotal_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxTotal.Text))
            {
                TotalProvider.SetError(txtBoxTotal, "El camp total no pot estar buit");
                e.Cancel = true;
            }
            else if (!IsNumber(txtBoxTotal.Text))
            {
                TotalProvider.SetError(txtBoxTotal, "El camp total no pot contenir lletres");
                e.Cancel = true;
            }
            else if (!IsGreaterAndEqualThanZero(txtBoxTotal.Text))
            {
                TotalProvider.SetError(txtBoxTotal, "El camp total no pot ser negatiu");
                e.Cancel = true;
            }
            else
            {
                TotalProvider.SetError(txtBoxTotal, "");
                e.Cancel = false;
            }
        }

        private bool IsNumber(string text)
        {
            return double.TryParse(text, out _);
        }

        private bool IsGreaterAndEqualThanZero(string text)
        {
            return double.Parse(text) >= 0;
        }

        private void btnPaginaAnterior_Click(object sender, EventArgs e)
        {
            if (paginaActual > 1)
            {
                paginaActual--;
                MostraDadesEnElDataGridView();
            }
        }

        private void btnPaginaSeguent_Click(object sender, EventArgs e)
        {
            int totalPaginas = (int)Math.Ceiling((double)comarquescsv.Count / tamañoPagina);
            if (paginaActual < totalPaginas)
            {
                paginaActual++;
                MostraDadesEnElDataGridView();
            }
        }
    }
}
