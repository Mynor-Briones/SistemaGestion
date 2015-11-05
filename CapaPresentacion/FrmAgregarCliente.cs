using CapaNegocio;
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
    public partial class FrmAgregarCliente : Form
    {
        Clientes _owner;

        public FrmAgregarCliente(Clientes owner)
        {
            _owner = owner;
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //direccion
            string calle = this.textBoxCalle.Text;
            string numero = this.textBoxNumero.Text;
            string depto = this.textBoxDepto.Text;
            string piso = this.textBoxPiso.Text;
            string cp = this.textBoxCP.Text;
            string ciudad = this.textBoxCiudad.Text;
            string provincia = this.textBoxProvincia.Text;
            string pais = this.textBoxPais.Text;

            List<string> dir = new List<string>();
            dir.Add(calle);
            dir.Add(numero);
            dir.Add(piso);
            dir.Add(depto);
            dir.Add(cp);
            dir.Add(ciudad);
            dir.Add(provincia);
            dir.Add(pais);

            
            //cliente
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            long cuil = 0;
            if(this.textBoxCuil.Text!="")
                cuil = long.Parse(this.textBoxCuil.Text);
            string razonSocial = this.textBoxRazonSocial.Text;
            long cuit = 0;
            if (this.textBoxCuit.Text != "")
                cuit = long.Parse(this.textBoxCuit.Text);
            string telFijo = this.textBoxTelFijo.Text;
            string telMovil = this.textBoxTelMovil.Text;
            string email = this.textBoxEmail.Text;

            int tipo = 0;
            if(radioButtonEmpresa.Checked==true)
                tipo = 2;
            else
                tipo = 1;

            String mensaje = NClientes.Insertar(nombre, apellido, cuil, razonSocial, cuit, telFijo, telMovil, email, tipo, dir);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Cliente {0} ha sido AGREGADO",
                    this.textBoxNombre.Text));
                this._owner.Refrescar();
                this.Close();
            }
            else
            {
                MensajeError(mensaje);
            }
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void radioButtonPersona_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPersona.Checked)
            {
                this.textBoxNombre.Enabled = true;
                this.textBoxApellido.Enabled = true;
                this.textBoxCuil.Enabled = true;
                this.textBoxRazonSocial.Enabled = false;
                this.textBoxCuit.Enabled = false;
                this.textBoxRazonSocial.Text = "";
                this.textBoxCuit.Text = "";
            }
            else
            {
                this.textBoxNombre.Enabled = false;
                this.textBoxApellido.Enabled = false;
                this.textBoxCuil.Enabled = false;
                this.textBoxRazonSocial.Enabled = true;
                this.textBoxCuit.Enabled = true;
                this.textBoxNombre.Text = "";
                this.textBoxApellido.Text = "";
                this.textBoxCuil.Text = "";     
            }
        }


    }
}
