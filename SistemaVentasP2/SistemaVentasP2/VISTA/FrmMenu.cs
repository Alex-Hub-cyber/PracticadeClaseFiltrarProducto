using SistemaVentasP2.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasP2
{
    public partial class FrmMenuu : Form
    {
        public FrmMenuu()
        {
            InitializeComponent();

            
        }

        public static FrmVenta frmVenta = new FrmVenta();
     
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.MdiParent = this;
            clientes.Show();

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {    
            FrmProductos productos = new FrmProductos();
            productos.MdiParent = this;
            productos.Show();

        }

        private void tablaDeDocuemntosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDocumentos documentos = new FrmDocumentos();
            documentos.MdiParent = this;
            documentos.Show();

        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarUsuarios agregar = new FrmAgregarUsuarios();
            agregar.MdiParent = this;
            agregar.Show();

        }

        private void tablaVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta.Show();
           
           
        }

        private void FrmMenuu_Load(object sender, EventArgs e)
        {

        }
    }

      
    }
    

