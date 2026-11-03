
using Entidades;
using MySql.Data.MySqlClient;
using System;

namespace Datos
{
    public class D_Usuario : D_Conexion
    {
        public static E_Usuario Login(string strUsuario)
        {
            try
            {
                using (MySqlConnection conexion =
                    new MySqlConnection(CadenaConexion))
                {
                    conexion.Open();

                    using (MySqlCommand cmd = new MySqlCommand(
                        "SELECT id, dsUsuario, dsPassword FROM usuarios WHERE dsUsuario = @usuario",
                        conexion))
                    {
                        cmd.Parameters.AddWithValue("@usuario", strUsuario);

                        using (MySqlDataReader fReader = cmd.ExecuteReader())
                        {
                            if (fReader.Read())
                            {
                                E_Usuario usuario = new E_Usuario();

                                usuario.id = fReader.GetInt32("id");
                                usuario.dsUsuario = fReader.GetString("dsUsuario");
                                usuario.HashPassword = (byte[])fReader["dsPassword"];

                                return usuario;
                            }
                        }
                    }
                }

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "Error al procesar la información: " + ex.Message, ex);
            }
        }
    }
}