using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class NClientes
    {
        public static DataTable ListarClientes(int opcion)
        {
            return new DClientes().ListarClientes(opcion);
        }      

        //public static DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        //{
        //    return new DClientes().Mostrar(parNumeroPagina, parRegistrosPorPagina);
        //}

        public static DataTable Mostrar()
        {
            return new DClientes().Mostrar();
        }

        public static DataTable Buscar(int opcion, string nombre)
        {
            return new DClientes().Buscar(opcion, nombre);
        }

        public static DClientes BuscarPorId(int id)
        {
            return new DClientes().BuscarPorId(id);
        }

        public static int Tamaño(int parRegistrosPorPagina)
        {
            return new DClientes().Tamaño(parRegistrosPorPagina);
        }
        
        

        public static String Eliminar(int Id_Cliente)
        {
            DClientes clientes = new DClientes();

            return clientes.Eliminar(Id_Cliente);
        }

        //public static String Insertar(String parNombre_Cliente, String parNombre_Contacto,
        //    String parDireccion, String parCiudad, String parRegion, String parPais,
        //    String parTelefono, String parFax, String parEmail)
        //{
        //    DClientes clientes = new DClientes();
        //    clientes.Nombre_Cliente = parNombre_Cliente;
        //    clientes.Apellido_Cliente = parNombre_Contacto;
        //    clientes.Telefono = parTelefono;
        //    clientes.Email = parEmail;

        //    return clientes.Insertar(clientes);
        //}

        public static String Insertar(String nombre, String apellido, long cuil, String razonSocial, long cuit,
            String telFijo, String telMovil, String email, int tipo, List<string> dir)
        {
            DClientes cliente = new DClientes();
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Cuil = cuil;
            cliente.Razon_Social = razonSocial;
            cliente.Cuit = cuit;
            cliente.Telefono_Fijo = telFijo;
            cliente.Telefono_Movil = telMovil;
            cliente.Email = email;
            cliente.Tipo_Cliente = tipo;

            return cliente.Insertar(cliente,dir);
        }

        //public static String Editar(int parId_Cliente, String parNombre_Cliente, String parNombre_Contacto,
        //    String parDireccion, String parCiudad, String parRegion, String parPais,
        //    String parTelefono, String parFax, String parEmail)
        //{
        //    DClientes clientes = new DClientes();
        //    clientes.Id_Cliente = parId_Cliente;
        //    clientes.Nombre_Cliente = parNombre_Cliente;
        //    clientes.Apellido_Cliente = parNombre_Contacto;
        //    clientes.Telefono = parTelefono;
        //    clientes.Email = parEmail;

        //    return clientes.Editar(clientes);
        //}

        public static String Editar(int id_cliente,String nombre, String apellido, long cuil, String razonSocial, long cuit,
            String telFijo, String telMovil, String email, int tipo, List<string> dir)
        {
            DClientes cliente = new DClientes();
            cliente.Id_Cliente = id_cliente;
            cliente.Nombre = nombre;
            cliente.Apellido = apellido;
            cliente.Cuil = cuil;
            cliente.Razon_Social = razonSocial;
            cliente.Cuit = cuit;
            cliente.Telefono_Fijo = telFijo;
            cliente.Telefono_Movil = telMovil;
            cliente.Email = email;
            cliente.Tipo_Cliente = tipo;

            return cliente.Editar(cliente, dir);
        }
    }
}
