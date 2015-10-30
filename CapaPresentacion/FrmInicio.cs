using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmInicio : Form
    {
        Pedidos pedidos;
        Productos productos;
        Clientes clientes;
        Pagos pagos;
        Caja caja;
        


        public FrmInicio()
        {
            InitializeComponent();

            if (pedidos == null)
            {
                pedidos = new Pedidos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pedidos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pedidos);
            }
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            if (clientes == null)
            {
                clientes = new Clientes();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(clientes);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(clientes);
            }
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            if (productos == null)
            {
                productos = new Productos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(productos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(productos);
            }
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            if (pedidos == null)
            {
                pedidos = new Pedidos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pedidos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pedidos);
            }
        }

        private void buttonPagos_Click(object sender, EventArgs e)
        {
            if (pagos == null)
            {
                pagos = new Pagos();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pagos);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(pagos);
            }
        }

        private void buttonCaja_Click(object sender, EventArgs e)
        {
            if (caja == null)
            {
                caja = new Caja();
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(caja);
            }
            else
            {
                this.panelContenedor.Controls.Clear();
                this.panelContenedor.Controls.Add(caja);
            }
        }
    }
}
