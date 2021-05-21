using SistemaVentasP2.DAO;
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
            ClsDCliente clsDDClientes = new ClsDCliente();

                    comboBox2.DataSource = clsDDClientes.cargarComboCliente();
                    comboBox2.DisplayMember = "nombreCliente";
                    comboBox2.ValueMember = "iDCliente";

            ClsDDocumento clsDDocumento = new ClsDDocumento();
                    comboBox1.DataSource =clsDDocumento.cargarComboDocumento();
                    comboBox1.DisplayMember = "nombreDocumento";
                    comboBox1.ValueMember = "iDDocumento";
              
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        { try {
                FrmBuscarProducto buscar = new FrmBuscarProducto();
                buscar.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            }
        private void DtgDeVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = DtgDeVentas.CurrentRow.Cells[0].Value.ToString();
            string nombre = DtgDeVentas.CurrentRow.Cells[1].Value.ToString();
            string precio = DtgDeVentas.CurrentRow.Cells[2].Value.ToString();

            FrmMenuu.frmVenta.TxtId.Text = id;
            FrmMenuu.frmVenta.TxtNombreProducto.Text = nombre;
            FrmMenuu.frmVenta.TxtCantidad.Text = precio;
            this.Close();

        }
    }
}
