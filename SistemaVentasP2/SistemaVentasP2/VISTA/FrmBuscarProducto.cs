using SistemaVentasP2.DAO;
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
    public partial class FrmBuscarProducto : Form
    {
        public FrmBuscarProducto()
        {
            InitializeComponent();
            cargarProductos();
        }
        void cargarProductos()
        {

            var Lista = new ClsDProducto();
            DtgBuscarProducto.Rows.Clear();


            foreach (var listarDatos in Lista.cargarProductoFiltro(txtBuscarProducto.Text))
            {


                DtgBuscarProducto.Rows.Add(listarDatos.idProducto, listarDatos.nombreProducto, listarDatos.precioProducto);

            }
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            cargarProductos();
        }


        private void DtgBuscarProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            String id = DtgBuscarProducto.CurrentRow.Cells[0].Value.ToString();
            String Nombre = DtgBuscarProducto.CurrentRow.Cells[1].Value.ToString();
            String Precio = DtgBuscarProducto.CurrentRow.Cells[2].Value.ToString();
           


            FrmVenta ventas = new FrmVenta();

            ventas.TxtId.Text = id;
            ventas.TxtNombreProducto.Text = Nombre;
            ventas.TxtPrecio.Text = Precio;
            ventas.Show();

            ///// ESTE CODIGO ES PARA QUE LO ABRA EN UN SOLO OBJETO, PERO NO ME FUNCIONA ASI QUE LE DEJE .EL QUE ABRE OTRO OBJETO.
            //FrmMenuu.frmVenta.TxtId.Text = id;
            //FrmMenuu.frmVenta.TxtNombreProducto.Text = Nombre;
            //FrmMenuu.frmVenta.TxtPrecio.Text = Precio;
            //this.Show();
            //this.Close();
        }

        private void FrmBuscarProducto_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

     
    }
    }


