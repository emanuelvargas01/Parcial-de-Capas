
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Datos
{
    public class D_Producto : D_Conexion
    {
        public static List<E_Producto> GetProductos(string filtro)
        {
            List<E_Producto> listaProductos = new List<E_Producto>();

            string query = "SELECT id, nombre, precio, cantidad, imagen FROM productos";

            if (!string.IsNullOrEmpty(filtro))
            {
                query += " WHERE id LIKE @filtro OR nombre LIKE @filtro OR precio LIKE @filtro OR cantidad LIKE @filtro";
            }

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    if (!string.IsNullOrEmpty(filtro))
                    {
                        cmd.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                    }

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            E_Producto producto = new E_Producto();

                            producto.Id = Convert.ToInt32(reader["id"]);
                            producto.Nombre = reader["nombre"].ToString();
                            producto.Precio = Convert.ToDecimal(reader["precio"]);
                            producto.Cantidad = Convert.ToInt32(reader["cantidad"]);
                            producto.Imagen = reader["imagen"] != DBNull.Value
                                ? (byte[])reader["imagen"]
                                : null;

                            listaProductos.Add(producto);
                        }
                    }
                }
            }

            return listaProductos;
        }

        public static bool InsertSeguro(Dictionary<string, object> data)
        {
            string columnas = string.Join(", ", data.Keys);
            string parametros = "@" + string.Join(", @", data.Keys);

            string query = $"INSERT INTO productos ({columnas}) VALUES ({parametros})";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    foreach (var dato in data)
                    {
                        cmd.Parameters.AddWithValue(
                            "@" + dato.Key,
                            dato.Value ?? DBNull.Value
                        );
                    }

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool UpdateSeguro(Dictionary<string, object> data, int id)
        {
            List<string> partes = new List<string>();

            foreach (var clave in data.Keys)
            {
                partes.Add($"{clave} = @{clave}");
            }

            string setClause = string.Join(", ", partes);

            string query = $"UPDATE productos SET {setClause} WHERE id = @idCondicion";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    foreach (var dato in data)
                    {
                        cmd.Parameters.AddWithValue(
                            "@" + dato.Key,
                            dato.Value ?? DBNull.Value
                        );
                    }

                    cmd.Parameters.AddWithValue("@idCondicion", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public static bool DeleteSeguro(int id)
        {
            string query = "DELETE FROM productos WHERE id = @idCondicion";

            using (MySqlConnection conexion = new MySqlConnection(CadenaConexion))
            {
                conexion.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@idCondicion", id);

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
