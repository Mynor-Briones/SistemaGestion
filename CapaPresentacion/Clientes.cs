using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Clientes : UserControl
    {
        public Clientes()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            //por defecto clientes empresas
            ListarClientes(2);
            
        }

        //carga al cargar el panel
        private void tableLayoutPanelGeneral_Paint(object sender, PaintEventArgs e)
        {
            if (radioButtonEmpresas.Checked)
            {
                ListarClientes(2);
            }
            else
            {
                ListarClientes(1);
            }
        }
                
        //busca clientes dependiendo el tipo (radiobutton)
        private void radioButtonPersonas_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonEmpresas.Checked)
            {
                ListarClientes(2);
            }
            else
            {
                ListarClientes(1);
            }
        }

        //busca clientes por el nombre
        private void textBoxBuscarNombre_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonEmpresas.Checked)
            {
                //busca clientes empresas
                BuscarClientes(2,textBoxBuscarNombre.Text);
            }
            else
            {
                //busca clientes personas
                BuscarClientes(1, textBoxBuscarNombre.Text);
            }            
        }

        



        /*Metodos de la vista*/

        //lista los clientes opcion 1(presonas) 2(empresas)
        public void ListarClientes(int opcion)
        {
            //this.dataGridViewClientes.DataSource = NClientes.ListarClientes(opcion);
            //this.dataGridViewClientes.AllowUserToAddRows = false;

            if (opcion == 1)
            {
                dataGridViewClientes.AutoGenerateColumns = false;
                dataGridViewClientes.Columns.Clear();

                dataGridViewClientes.Columns.Add("ID", "ID");
                dataGridViewClientes.Columns.Add("NOMBRE", "NOMBRE");
                dataGridViewClientes.Columns.Add("APELLIDO", "APELLIDO");
                dataGridViewClientes.Columns.Add("CUIL", "CUIL");
                dataGridViewClientes.Columns.Add("TELEFONO FIJO", "TELEFONO FIJO");
                dataGridViewClientes.Columns.Add("TELEFONO MOVIL", "TELEFONO MOVIL");
                dataGridViewClientes.Columns.Add("EMAIL", "EMAIL");
                dataGridViewClientes.Columns[0].DataPropertyName = "ID";
                dataGridViewClientes.Columns[1].DataPropertyName = "NOMBRE";
                dataGridViewClientes.Columns[2].DataPropertyName = "APELLIDO";
                dataGridViewClientes.Columns[3].DataPropertyName = "CUIL";
                dataGridViewClientes.Columns[4].DataPropertyName = "TELEFONO FIJO";
                dataGridViewClientes.Columns[5].DataPropertyName = "TELEFONO MOVIL";
                dataGridViewClientes.Columns[6].DataPropertyName = "EMAIL";
                
                this.dataGridViewClientes.DataSource = NClientes.ListarClientes(opcion);
            }
            else
            {
                dataGridViewClientes.AutoGenerateColumns = false;
                dataGridViewClientes.Columns.Clear();

                dataGridViewClientes.Columns.Add("ID", "ID");
                dataGridViewClientes.Columns.Add("RAZON SOCIAL", "RAZON SOCIAL");
                dataGridViewClientes.Columns.Add("CUIT", "CUIT");
                dataGridViewClientes.Columns.Add("TELEFONO FIJO", "TELEFONO FIJO");
                dataGridViewClientes.Columns.Add("TELEFONO MOVIL", "TELEFONO MOVIL");
                dataGridViewClientes.Columns.Add("EMAIL", "EMAIL");
                dataGridViewClientes.Columns[0].DataPropertyName = "ID";
                dataGridViewClientes.Columns[1].DataPropertyName = "RAZON SOCIAL";
                dataGridViewClientes.Columns[2].DataPropertyName = "CUIT";
                dataGridViewClientes.Columns[3].DataPropertyName = "TELEFONO FIJO";
                dataGridViewClientes.Columns[4].DataPropertyName = "TELEFONO MOVIL";
                dataGridViewClientes.Columns[5].DataPropertyName = "EMAIL";

                this.dataGridViewClientes.DataSource = NClientes.ListarClientes(opcion);
            }
        }

        //buscalo clientes segun el tipo (persona o empresa) y el nombre (nombre o razon social)
        public void BuscarClientes(int opcion,string nombre)
        {
            this.dataGridViewClientes.DataSource = NClientes.Buscar(opcion,nombre);
            this.dataGridViewClientes.AllowUserToAddRows = false;
        }

        //carga la pantalla como al inicio
        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            ListarClientes(2);
            radioButtonEmpresas.Checked = true;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAgregarCliente nuevoCliente = new FrmAgregarCliente(this);
            nuevoCliente.ShowDialog();
        }

        public void Refrescar()
        {
            if (radioButtonEmpresas.Checked)
            {
                ListarClientes(2);
            }
            else
            {
                ListarClientes(1);
            }

            this.textBoxBuscarNombre.Text = String.Empty;
        }

        public void Mensaje(String mensaje)
        {
            this.labelMensajes.Text = mensaje;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dataGridViewClientes.Rows.Count > 0)
                {
                    DialogResult confirmacion = MessageBox.Show("¿Seguro deseas eliminar este cliente?", "Eliminar Cliente",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (confirmacion == DialogResult.OK)
                    {
                        String mensaje = NClientes.Eliminar(Convert.ToInt32(ObtenerSeleccion().Cells["ID"].Value));
                        if (mensaje == "Y")
                        {
                            Mensaje(String.Format("El Cliente {0} ha sido ELIMINADO",
                                Convert.ToString(ObtenerSeleccion().Cells["NOMBRE"].Value) + " " + ObtenerSeleccion().Cells["APELLIDO"].Value));
                            Refrescar();
                        }
                        else
                        {
                            MensajeError(mensaje);
                            Refrescar();
                        }
                    }
                }
                else
                {
                    MensajeError("Debes seleccionar una fila para eliminar");
                }
            }
            catch (Exception ex)
            {
                MensajeError(ex.Message);
            }
        }

        public DataGridViewRow ObtenerSeleccion()
        {
            DataGridViewRow filaSeleccionada = this.dataGridViewClientes.Rows[this.dataGridViewClientes.CurrentRow.Index];
            return filaSeleccionada;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

 
    }
}
