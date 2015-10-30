﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DClientes
    {
        public int Id_Cliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono_Fijo { get; set; }
        public string Telefono_Movil { get; set; }
        public string Email { get; set; }
        public long Cuil { get; set; }
        public long Cuit { get; set; }
        public string Razon_Social { get; set; }
        public int direccion { get; set; }
        public int Tipo_Cliente { get; set; }

        /**/
        public DClientes()
        {

        }

        /**/
        public DClientes(int id_cliente, string nombre, string apellido, string telefono_fijo, string telefono_movil,
            string email, long cuil, long cuit, string razon_social, int direccion, int tipo_cliente)
        {
            this.Id_Cliente = id_cliente;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Telefono_Fijo = telefono_fijo;
            this.Telefono_Movil = telefono_movil;
            this.Email = email;
            this.Cuil = cuil;
            this.Cuit = cuit;
            this.Razon_Social = razon_social;
            this.direccion = direccion;
            this.Tipo_Cliente = tipo_cliente;
            
        }

        /**/
        public DataTable ListarClientes(int opcion)
        {
            DataTable TablaDatos = new DataTable("CLIENTES");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;

                string query = "";

                if (opcion == 1)
                {
                    query = "SELECT [id_cliente] AS ID, [nombre] AS 'NOMBRE', [apellido] AS 'APELLIDO' " +
                                   ",[telefono_fijo] AS 'TELEFONO FIJO', [telefono_movil] AS 'TELEFONO MOVIL', [email] AS 'EMAIL'" +
                                   ",[cuil] AS 'CUIL'FROM [BD_Gestion].[dbo].[CLIENTES]" +
                                   "WHERE [tipo_cliente_id] = " + opcion;
                }
                else
                {
                    query = "SELECT [id_cliente] AS ID,[razon_social] AS 'RAZON SOCIAL',[telefono_fijo] AS 'TELEFONO FIJO'"+
                                   ", [telefono_movil] AS 'TELEFONO MOVIL', [email] AS 'EMAIL'" +
                                   ", [cuit] AS 'CUIT' FROM [BD_Gestion].[dbo].[CLIENTES]" +
                                   "WHERE [tipo_cliente_id] = " + opcion;
                }

                SqlComando.CommandText = query;
                SqlComando.CommandType = CommandType.Text;

                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar listar clientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        //public DataTable Mostrar(int parNumeroPagina, int parRegistrosPorPagina)
        //{
        //    DataTable TablaDatos = new DataTable("Ventas.Clientes");
        //    SqlConnection SqlConexion = new SqlConnection();

        //    try
        //    {
        //        SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
        //        SqlConexion.Open();

        //        SqlCommand SqlComando = new SqlCommand();
        //        SqlComando.Connection = SqlConexion;
        //        SqlComando.CommandText = "Ventas.MostrarClientes";
        //        SqlComando.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParNumeroPagina = new SqlParameter();
        //        ParNumeroPagina.ParameterName = "@NumeroPagina";
        //        ParNumeroPagina.SqlDbType = SqlDbType.Int;
        //        ParNumeroPagina.Value = parNumeroPagina;
        //        SqlComando.Parameters.Add(ParNumeroPagina);

        //        SqlParameter ParRegistrosPorPagina = new SqlParameter();
        //        ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
        //        ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
        //        ParRegistrosPorPagina.Value = parRegistrosPorPagina;
        //        SqlComando.Parameters.Add(ParRegistrosPorPagina);

        //        SqlComando.ExecuteNonQuery();

        //        SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
        //        SqlAdaptadorDatos.Fill(TablaDatos);
        //    }

        //    catch (Exception ex)
        //    {
        //        TablaDatos = null;
        //        throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.MostrarClientes. " + ex.Message, ex);
        //    }

        //    finally
        //    {
        //        SqlConexion.Close();
        //    }

        //    return TablaDatos;
        //}

        public DataTable Mostrar()
        {
            DataTable TablaDatos = new DataTable("Clientes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "select * from Clientes";
                SqlComando.CommandType = CommandType.Text;
                
                SqlComando.ExecuteNonQuery();

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.MostrarClientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return TablaDatos;
        }

        public int Tamaño(int parRegistrosPorPagina)
        {
            SqlConnection SqlConexion = new SqlConnection();
            int totalPaginas = 1;

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.TamañoClientes";
                SqlComando.CommandType = CommandType.StoredProcedure;

                SqlParameter ParRegistrosPorPagina = new SqlParameter();
                ParRegistrosPorPagina.ParameterName = "@RegistrosPorPagina";
                ParRegistrosPorPagina.SqlDbType = SqlDbType.Int;
                ParRegistrosPorPagina.Value = parRegistrosPorPagina;
                SqlComando.Parameters.Add(ParRegistrosPorPagina);

                SqlParameter ParTotalPaginas = new SqlParameter();
                ParTotalPaginas.ParameterName = "@TotalPaginas";
                ParTotalPaginas.SqlDbType = SqlDbType.Int;
                ParTotalPaginas.Direction = ParameterDirection.Output;
                SqlComando.Parameters.Add(ParTotalPaginas);

                SqlComando.ExecuteNonQuery();

                totalPaginas = (int)SqlComando.Parameters["@TotalPaginas"].Value;
            }

            catch (Exception ex)
            {
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.TamañoClientes. " + ex.Message, ex);
            }

            finally
            {
                SqlConexion.Close();
            }

            return totalPaginas;
        }

        public DataTable Buscar(int opcion, string nombre)
        {
            DataTable TablaDatos = new DataTable("CLIENTES");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;

                string query = "";

                if (opcion == 1)
                {
                    query = "SELECT [id_cliente] AS ID, [nombre] AS 'NOMBRE', [apellido] AS 'APELLIDO' " +
                                   ",[telefono_fijo] AS 'TELEFONO FIJO', [telefono_movil] AS 'TELEFONO MOVIL', [email] AS 'EMAIL'" +
                                   ",[cuil] AS 'CUIL'FROM [BD_Gestion].[dbo].[CLIENTES]" +
                                   "WHERE [tipo_cliente_id] = " + opcion +
                                   " AND [nombre] like '%"+nombre+"%'";
                }
                else
                {
                    query = "SELECT [id_cliente] AS ID,[razon_social] AS 'RAZON SOCIAL',[telefono_fijo] AS 'TELEFONO FIJO'" +
                                   ", [telefono_movil] AS 'TELEFONO MOVIL', [email] AS 'EMAIL'" +
                                   ", [cuit] AS 'CUIT' FROM [BD_Gestion].[dbo].[CLIENTES]" +
                                   "WHERE [tipo_cliente_id] = " + opcion+
                                   " AND [razon_social] like '%" + nombre + "%'";
                }

                SqlComando.CommandText = query;
                SqlComando.CommandType = CommandType.Text;              

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar buscar cliente. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return TablaDatos;
        }

        public DClientes BuscarPorId(int id)
        {
            DClientes cliente = new DClientes();
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;

                SqlComando.CommandText = "select * from Clientes where Id_Cliente =" + id;
                
                SqlComando.CommandType = CommandType.Text;

                SqlDataReader reader = SqlComando.ExecuteReader();               

                foreach (DataRow row in reader)
                {
                    cliente.Id_Cliente = id;
                    cliente.Nombre = row[1].ToString();
                    cliente.Apellido = row[2].ToString();
                    //cliente.Telefono = row[3].ToString();
                    cliente.Email = row[4].ToString();
                }
            }

            catch (Exception ex)
            {
                cliente = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.BuscarCliente. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return cliente;
        }

        public DataTable Buscar(DClientes parClientes)
        {
            DataTable TablaDatos = new DataTable("Ventas.Clientes");
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "Ventas.BuscarCliente";
                SqlComando.CommandType = CommandType.StoredProcedure;

                //SqlParameter ParNombre_Cliente_Buscado = new SqlParameter();
                //ParNombre_Cliente_Buscado.ParameterName = "@NombreClienteBuscado";
                //ParNombre_Cliente_Buscado.SqlDbType = SqlDbType.VarChar;
                //ParNombre_Cliente_Buscado.Size = parClientes.Nombre_Cliente_Buscado.Length;
                //ParNombre_Cliente_Buscado.Value = parClientes.Nombre_Cliente_Buscado;
                //SqlComando.Parameters.Add(ParNombre_Cliente_Buscado);

                SqlDataAdapter SqlAdaptadorDatos = new SqlDataAdapter(SqlComando);
                SqlAdaptadorDatos.Fill(TablaDatos);
            }

            catch (Exception ex)
            {
                TablaDatos = null;
                throw new Exception("Error al intentar ejecutar el procedimiento almacenado Ventas.BuscarCliente. " + ex.Message, ex);
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return TablaDatos;
        }

        //public string Insertar(DClientes parClientes)
        //{
        //    string Respuesta = "";
        //    SqlConnection SqlConexion = new SqlConnection();

        //    try
        //    {
        //        SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
        //        SqlConexion.Open();

        //        SqlCommand SqlComando = new SqlCommand();
        //        SqlComando.Connection = SqlConexion;
        //        SqlComando.CommandText = "Ventas.InsertarCliente";
        //        SqlComando.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParNombre_Cliente = new SqlParameter();
        //        ParNombre_Cliente.ParameterName = "@Nombre_Cliente";
        //        ParNombre_Cliente.SqlDbType = SqlDbType.VarChar;
        //        ParNombre_Cliente.Size = parClientes.Nombre_Cliente.Length;
        //        ParNombre_Cliente.Value = parClientes.Nombre_Cliente;
        //        SqlComando.Parameters.Add(ParNombre_Cliente);

        //        SqlParameter ParNombre_Contacto = new SqlParameter();
        //        ParNombre_Contacto.ParameterName = "@Nombre_Contacto";
        //        ParNombre_Contacto.SqlDbType = SqlDbType.VarChar;
        //        ParNombre_Contacto.Size = parClientes.Apellido_Cliente.Length;
        //        ParNombre_Contacto.Value = parClientes.Apellido_Cliente;
        //        SqlComando.Parameters.Add(ParNombre_Contacto);

        //        //SqlParameter ParDireccion = new SqlParameter();
        //        //ParDireccion.ParameterName = "@Direccion";
        //        //ParDireccion.SqlDbType = SqlDbType.VarChar;
        //        //ParDireccion.Size = parClientes.Direccion.Length;
        //        //ParDireccion.Value = parClientes.Direccion;
        //        //SqlComando.Parameters.Add(ParDireccion);

        //        //SqlParameter ParCiudad = new SqlParameter();
        //        //ParCiudad.ParameterName = "@Ciudad";
        //        //ParCiudad.SqlDbType = SqlDbType.VarChar;
        //        //ParCiudad.Size = parClientes.Ciudad.Length;
        //        //ParCiudad.Value = parClientes.Ciudad;
        //        //SqlComando.Parameters.Add(ParCiudad);

        //        //SqlParameter ParRegion = new SqlParameter();
        //        //ParRegion.ParameterName = "@Region";
        //        //ParRegion.SqlDbType = SqlDbType.VarChar;
        //        //ParRegion.Size = parClientes.Region.Length;
        //        //ParRegion.Value = parClientes.Region;
        //        //SqlComando.Parameters.Add(ParRegion);

        //        //SqlParameter ParPais = new SqlParameter();
        //        //ParPais.ParameterName = "@Pais";
        //        //ParPais.SqlDbType = SqlDbType.VarChar;
        //        //ParPais.Size = parClientes.Pais.Length;
        //        //ParPais.Value = parClientes.Pais;
        //        //SqlComando.Parameters.Add(ParPais);

        //        SqlParameter ParTelefono = new SqlParameter();
        //        ParTelefono.ParameterName = "@Telefono";
        //        ParTelefono.SqlDbType = SqlDbType.VarChar;
        //        ParTelefono.Size = parClientes.Telefono.Length;
        //        ParTelefono.Value = parClientes.Telefono;
        //        SqlComando.Parameters.Add(ParTelefono);

        //        //SqlParameter ParFax = new SqlParameter();
        //        //ParFax.ParameterName = "@Fax";
        //        //ParFax.SqlDbType = SqlDbType.VarChar;
        //        //ParFax.Size = parClientes.Fax.Length;
        //        //ParFax.Value = parClientes.Fax;
        //        //SqlComando.Parameters.Add(ParFax);

        //        SqlParameter ParEmail = new SqlParameter();
        //        ParEmail.ParameterName = "@Email";
        //        ParEmail.SqlDbType = SqlDbType.VarChar;
        //        ParEmail.Size = parClientes.Email.Length;
        //        ParEmail.Value = parClientes.Email;
        //        SqlComando.Parameters.Add(ParEmail);

        //        SqlComando.ExecuteNonQuery();
        //        Respuesta = "Y";
        //    }

        //    catch (SqlException ex)
        //    {
        //        if (ex.Number == 8152)
        //        {
        //            Respuesta = "Has introducido demasiados caracteres en uno de los campos";
        //        }
        //        else if (ex.Number == 2627)
        //        {
        //            Respuesta = "Ya existe un cliente con ese Nombre";
        //        }
        //        else if (ex.Number == 515)
        //        {
        //            Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email";
        //        }
        //        else
        //        {
        //            Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.InsertarCliente. " + ex.Message;
        //        }
        //    }

        //    finally
        //    {
        //        if (SqlConexion.State == ConnectionState.Open)
        //        {
        //            SqlConexion.Close();
        //        }
        //    }

        //    return Respuesta;
        //}

        public string Insertar(DClientes cliente)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                //SqlComando.CommandText = "insert into Clientes values('"+cliente.Nombre + "','" + cliente.Apellido + "'," + cliente.Telefono + ",'" + cliente.Email+ "')";
                SqlComando.CommandType = CommandType.Text;
                                
                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un cliente con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.InsertarCliente. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        //public string Eliminar(DClientes parClientes)
        //{
        //    string Respuesta = "";
        //    SqlConnection SqlConexion = new SqlConnection();

        //    try
        //    {
        //        SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
        //        SqlConexion.Open();

        //        SqlCommand SqlComando = new SqlCommand();
        //        SqlComando.Connection = SqlConexion;
        //        SqlComando.CommandText = "Ventas.EliminarCliente";
        //        SqlComando.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParId_Cliente = new SqlParameter();
        //        ParId_Cliente.ParameterName = "@Id_Cliente";
        //        ParId_Cliente.SqlDbType = SqlDbType.Int;
        //        ParId_Cliente.Value = parClientes.Id_Cliente;
        //        SqlComando.Parameters.Add(ParId_Cliente);

        //        SqlComando.ExecuteNonQuery();
        //        Respuesta = "Y";
        //    }

        //    catch (SqlException ex)
        //    {
        //        if (ex.Number == 547)
        //        {
        //            Respuesta = "No puedes eliminar un cliente que cuenta con uno o varios Pedidos. Debes eliminar o actualizar sus Pedidos antes de eliminar el cliente.";
        //        }

        //        else
        //        {
        //            Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EliminarCliente. " + ex.Message;
        //        }
        //    }

        //    finally
        //    {
        //        if (SqlConexion.State == ConnectionState.Open)
        //        {
        //            SqlConexion.Close();
        //        }
        //    }

        //    return Respuesta;
        //}

        public string Eliminar(int id)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                SqlComando.CommandText = "delete from Clientes where Id_Cliente = " + id;
                SqlComando.CommandType = CommandType.Text;

                
                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Respuesta = "No puedes eliminar un cliente que cuenta con uno o varios Pedidos. Debes eliminar o actualizar sus Pedidos antes de eliminar el cliente.";
                }

                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EliminarCliente. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }

        //public string Editar(DClientes parClientes)
        //{
        //    string Respuesta = "";
        //    SqlConnection SqlConexion = new SqlConnection();

        //    try
        //    {
        //        SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
        //        SqlConexion.Open();

        //        SqlCommand SqlComando = new SqlCommand();
        //        SqlComando.Connection = SqlConexion;
        //        SqlComando.CommandText = "Ventas.EditarCliente";
        //        SqlComando.CommandType = CommandType.StoredProcedure;

        //        SqlParameter ParId_Cliente = new SqlParameter();
        //        ParId_Cliente.ParameterName = "@Id_Cliente";
        //        ParId_Cliente.SqlDbType = SqlDbType.Int;
        //        ParId_Cliente.Value = parClientes.Id_Cliente;
        //        SqlComando.Parameters.Add(ParId_Cliente);

        //        SqlParameter ParNombre_Cliente = new SqlParameter();
        //        ParNombre_Cliente.ParameterName = "@Nombre_Cliente";
        //        ParNombre_Cliente.SqlDbType = SqlDbType.VarChar;
        //        ParNombre_Cliente.Size = parClientes.Nombre_Cliente.Length;
        //        ParNombre_Cliente.Value = parClientes.Nombre_Cliente;
        //        SqlComando.Parameters.Add(ParNombre_Cliente);

        //        SqlParameter ParNombre_Contacto = new SqlParameter();
        //        ParNombre_Contacto.ParameterName = "@Nombre_Contacto";
        //        ParNombre_Contacto.SqlDbType = SqlDbType.VarChar;
        //        ParNombre_Contacto.Size = parClientes.Apellido_Cliente.Length;
        //        ParNombre_Contacto.Value = parClientes.Apellido_Cliente;
        //        SqlComando.Parameters.Add(ParNombre_Contacto);

        //        //SqlParameter ParDireccion = new SqlParameter();
        //        //ParDireccion.ParameterName = "@Direccion";
        //        //ParDireccion.SqlDbType = SqlDbType.VarChar;
        //        //ParDireccion.Size = parClientes.Direccion.Length;
        //        //ParDireccion.Value = parClientes.Direccion;
        //        //SqlComando.Parameters.Add(ParDireccion);

        //        //SqlParameter ParCiudad = new SqlParameter();
        //        //ParCiudad.ParameterName = "@Ciudad";
        //        //ParCiudad.SqlDbType = SqlDbType.VarChar;
        //        //ParCiudad.Size = parClientes.Ciudad.Length;
        //        //ParCiudad.Value = parClientes.Ciudad;
        //        //SqlComando.Parameters.Add(ParCiudad);

        //        //SqlParameter ParRegion = new SqlParameter();
        //        //ParRegion.ParameterName = "@Region";
        //        //ParRegion.SqlDbType = SqlDbType.VarChar;
        //        //ParRegion.Size = parClientes.Region.Length;
        //        //ParRegion.Value = parClientes.Region;
        //        //SqlComando.Parameters.Add(ParRegion);

        //        //SqlParameter ParPais = new SqlParameter();
        //        //ParPais.ParameterName = "@Pais";
        //        //ParPais.SqlDbType = SqlDbType.VarChar;
        //        //ParPais.Size = parClientes.Pais.Length;
        //        //ParPais.Value = parClientes.Pais;
        //        //SqlComando.Parameters.Add(ParPais);

        //        SqlParameter ParTelefono = new SqlParameter();
        //        ParTelefono.ParameterName = "@Telefono";
        //        ParTelefono.SqlDbType = SqlDbType.VarChar;
        //        ParTelefono.Size = parClientes.Telefono.Length;
        //        ParTelefono.Value = parClientes.Telefono;
        //        SqlComando.Parameters.Add(ParTelefono);

        //        //SqlParameter ParFax = new SqlParameter();
        //        //ParFax.ParameterName = "@Fax";
        //        //ParFax.SqlDbType = SqlDbType.VarChar;
        //        //ParFax.Size = parClientes.Fax.Length;
        //        //ParFax.Value = parClientes.Fax;
        //        //SqlComando.Parameters.Add(ParFax);

        //        SqlParameter ParEmail = new SqlParameter();
        //        ParEmail.ParameterName = "@Email";
        //        ParEmail.SqlDbType = SqlDbType.VarChar;
        //        ParEmail.Size = parClientes.Email.Length;
        //        ParEmail.Value = parClientes.Email;
        //        SqlComando.Parameters.Add(ParEmail);

        //        SqlComando.ExecuteNonQuery();
        //        Respuesta = "Y";
        //    }

        //    catch (SqlException ex)
        //    {
        //        if (ex.Number == 8152)
        //        {
        //            Respuesta = "Has introducido demasiados caracteres en uno de los campos.";
        //        }
        //        else if (ex.Number == 2627)
        //        {
        //            Respuesta = "Ya existe un cliente con ese Nombre";
        //        }
        //        else if (ex.Number == 515)
        //        {
        //            Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email";
        //        }
        //        else
        //        {
        //            Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.EditarCliente. " + ex.Message;
        //        }
        //    }

        //    finally
        //    {
        //        if (SqlConexion.State == ConnectionState.Open)
        //        {
        //            SqlConexion.Close();
        //        }
        //    }

        //    return Respuesta;
        //}

        public string Editar(DClientes cliente)
        {
            string Respuesta = "";
            SqlConnection SqlConexion = new SqlConnection();

            try
            {
                SqlConexion.ConnectionString = DConexion.CnBDEmpresa;
                SqlConexion.Open();

                SqlCommand SqlComando = new SqlCommand();
                SqlComando.Connection = SqlConexion;
                //SqlComando.CommandText = "update Clientes set Nombre_Cliente ='" + cliente.Nombre + "', Apellido_Cliente='" + cliente.Apellido + "', Telefono=" + cliente.Telefono + ",Email='" + cliente.Email + "' where Id_Cliente="+Id_Cliente;
                SqlComando.CommandType = CommandType.Text;

                SqlComando.ExecuteNonQuery();
                Respuesta = "Y";
            }

            catch (SqlException ex)
            {
                if (ex.Number == 8152)
                {
                    Respuesta = "Has introducido demasiados caracteres en uno de los campos";
                }
                else if (ex.Number == 2627)
                {
                    Respuesta = "Ya existe un cliente con ese Nombre";
                }
                else if (ex.Number == 515)
                {
                    Respuesta = "Sólo puedes dejar vacíos los campos Nombre de Contacto, Región, País, Teléfono, Fax y Email";
                }
                else
                {
                    Respuesta = "Error al intentar ejecutar el procedimiento almacenado Ventas.InsertarCliente. " + ex.Message;
                }
            }

            finally
            {
                if (SqlConexion.State == ConnectionState.Open)
                {
                    SqlConexion.Close();
                }
            }

            return Respuesta;
        }
    }
}