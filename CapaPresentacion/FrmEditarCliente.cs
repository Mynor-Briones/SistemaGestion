using CapaNegocio;
using CapaDatos;
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
    public partial class FrmEditarCliente : Form
    {
        Clientes _owner;
        int Id_Cliente;        
        int idDireccion;

        public FrmEditarCliente()
        {
            InitializeComponent();
        }

        public FrmEditarCliente(Clientes owner)
        {
            _owner = owner;
            InitializeComponent();

            this.Id_Cliente = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID"].Value);
            this.textBoxNombre.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["NOMBRE"].Value);
            this.textBoxApellido.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["APELLIDO"].Value);
            this.textBoxCuil.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["CUIL"].Value);
            this.textBoxRazonSocial.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["RAZON SOCIAL"].Value);
            this.textBoxCuit.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["CUIT"].Value);
            this.textBoxTelFijo.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["TELEFONO FIJO"].Value);
            this.textBoxTelMovil.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["TELEFONO MOVIL"].Value);
            this.textBoxEmail.Text = Convert.ToString(_owner.ObtenerSeleccion().Cells["EMAIL"].Value);

            int tipoCliente = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["TIPO CLIENTE"].Value);
            if (tipoCliente == 1)
                radioButtonPersona.Checked=true;
            else
                radioButtonEmpresa.Checked=true;

            idDireccion = Convert.ToInt32(_owner.ObtenerSeleccion().Cells["ID DIRECCION"].Value);

            DDireccion direccion = NDireccion.BuscarPorId(idDireccion);

            this.textBoxCalle.Text = direccion.Calle;
            this.textBoxNumero.Text = direccion.Numero.ToString();
            this.textBoxPiso.Text = direccion.Piso;
            this.textBoxDepto.Text = direccion.Departamento;
            this.textBoxCiudad.Text = direccion.Ciudad;
            this.textBoxProvincia.Text = direccion.Provincia;
            this.textBoxPais.Text = direccion.Pais;
            this.textBoxCP.Text = direccion.Codigo_Postal.ToString();
            //recuperar datos de direccion y mostrarlos

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
            string id_direccion = this.idDireccion.ToString();

            List<string> dir = new List<string>();
            dir.Add(calle);
            dir.Add(numero);
            dir.Add(piso);
            dir.Add(depto);
            dir.Add(cp);
            dir.Add(ciudad);
            dir.Add(provincia);
            dir.Add(pais);
            dir.Add(id_direccion);


            //cliente
            string nombre = this.textBoxNombre.Text;
            string apellido = this.textBoxApellido.Text;
            long cuil = 0;
            if (this.textBoxCuil.Text != "")
                cuil = long.Parse(this.textBoxCuil.Text);
            string razonSocial = this.textBoxRazonSocial.Text;
            long cuit = 0;
            if (this.textBoxCuit.Text != "")
                cuit = long.Parse(this.textBoxCuit.Text);
            string telFijo = this.textBoxTelFijo.Text;
            string telMovil = this.textBoxTelMovil.Text;
            string email = this.textBoxEmail.Text;

            int tipo = 0;
            if (radioButtonEmpresa.Checked == true)
                tipo = 2;
            else
                tipo = 1;

            String mensaje = NClientes.Editar(Id_Cliente, nombre, apellido, cuil, razonSocial, cuit, telFijo, telMovil, email, tipo, dir);

            if (mensaje == "Y")
            {
                this._owner.Mensaje(String.Format("El Cliente {0} ha sido EDITADO", this.textBoxNombre.Text+" "+this.textBoxApellido.Text));
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
    }
}
