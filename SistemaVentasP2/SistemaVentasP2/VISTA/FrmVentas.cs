using SistemaVentasP2.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasP2.VISTA
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            using (sistema_ventasEntities db = new sistema_ventasEntities())
            {
                try
                {
                    var consultacliente = db.tb_cliente.ToList();

                    comboBox2.DataSource = consultacliente;
                    comboBox2.DisplayMember = "nombreCliente";
                    comboBox2.ValueMember = "iDCliente";

                    var consultadocumento = db.tb_documento.ToList();

                    comboBox1.DataSource = consultadocumento;
                    comboBox1.DisplayMember = "nombreDocumento";
                    comboBox1.ValueMember = "iDDocumento";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarProducto  buscar = new FrmBuscarProducto();
            buscar.Show();
        }

        private void DtgDeVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DtgDeVentas.CurrentRow.Cells[0].Value.ToString();
            string nombre = DtgDeVentas.CurrentRow.Cells[1].Value.ToString();
            string precio = DtgDeVentas.CurrentRow.Cells[2].Value.ToString();



            this.Close();

        }
    }
}
