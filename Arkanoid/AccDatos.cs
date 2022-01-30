﻿using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arkanoid
{
    class AccDatos
    {
        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=1234;database=sakila;";
        MySqlConnection databaseConnection;

        public AccDatos()
        {
            databaseConnection = new MySqlConnection(connectionString);  //constructor de acceso a la base de datos.
        }
        public AccDatos(string servidorDatos, string puerto, string u, string pwd, string bbdd)
        {

        }
        private void EstablecerConexion()
        {
            databaseConnection.Open();
        }

        public void CerrarConexion()
        {
            databaseConnection.Close();
        }

        public int EjecutarProcedimiento(string nombrePA,
                                                    List<object> pIN)
        //se puede pasar la lista de parametros junto con la lista de los objetos 
        {
            MySqlCommand cmd = new MySqlCommand(nombrePA, databaseConnection);

            // if(nombrePA == "AgregarPelicula")
            // {
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@valor1", 20);
            cmd.Parameters.AddWithValue("@valor2", 20);
                        

            List<object> salidaPA = new List<object>();
            cmd.Parameters.Add(new MySqlParameter("@retornar", MySqlDbType.Int32));
            cmd.Parameters["@retornar"].Direction = ParameterDirection.Output;
            //}

            EstablecerConexion();
            cmd.ExecuteNonQuery();
            int salida = (int)cmd.Parameters["@retornar"].Value;
            //salidaPA.Add(salida);

            CerrarConexion();
            return salida; //Lista<Object>
        }
        //public List<object> EjecutarProcedimiento(string nombrePA,
        //                                            List<object> pIN)
        ////se puede pasar la lista de parametros junto con la lista de los objetos 
        //{
        //    MySqlCommand cmd = new MySqlCommand(nombrePA, databaseConnection);

        //    // if(nombrePA == "AgregarPelicula")
        //    // {
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@_title", pIN[0]);
        //    cmd.Parameters.AddWithValue("@_description", pIN[1]);
        //    cmd.Parameters.AddWithValue("@_release_year", pIN[2]);
        //    cmd.Parameters.AddWithValue("@_language_id", pIN[3]);
        //    cmd.Parameters.AddWithValue("@_original_language_id", pIN[4]);
        //    cmd.Parameters.AddWithValue("@_rental_duration", pIN[5]);
        //    cmd.Parameters.AddWithValue("@_rental_rate", pIN[6]);
        //    cmd.Parameters.AddWithValue("@_length", pIN[7]);
        //    cmd.Parameters.AddWithValue("@_replacement_cost", pIN[8]);
        //    cmd.Parameters.AddWithValue("@_rating", pIN[9]);
        //    cmd.Parameters.AddWithValue("@_special_features", pIN[10]);

        //    List<object> salidaPA = new List<object>();
        //    cmd.Parameters.Add(new MySqlParameter("@_salida", MySqlDbType.Int32));
        //    cmd.Parameters["@_salida"].Direction = ParameterDirection.Output;
        //    //}

        //    EstablecerConexion();
        //    cmd.ExecuteNonQuery();
        //    int salida = (int)cmd.Parameters["@_salida"].Value;
        //    salidaPA.Add(salida);

        //    CerrarConexion();
        //    return salidaPA; //Lista<Object>
        //}

        //public void EjecutarProcedimiento(string nombrePA,
        //                                            List<string> pNames,
        //                                            List<object> pIN)
        //{
        //    MySqlCommand cmd = new MySqlCommand(nombrePA, databaseConnection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    for (int i = 0; i < pNames.Count; i++)
        //    {
        //        cmd.Parameters.AddWithValue("@" + pNames[i], pIN[i]);
        //    }

        //    EstablecerConexion();
        //    cmd.ExecuteNonQuery();

        //    CerrarConexion();

        //}


        //public List<object> EjecutarProcedimiento(string nombrePA,
        //                                            List<string> pNames,
        //                                            List<object> pIN,
        //                                            List<object> pNamesOut)
        //{
        //    MySqlCommand cmd = new MySqlCommand(nombrePA, databaseConnection);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    for (int i = 0; i < pNames.Count; i++)
        //    {
        //        cmd.Parameters.AddWithValue("@" + pNames[i], pIN[i]);
        //    }

        //    for (int i = 0; i < pNamesOut.Count; i++)
        //    {
        //        cmd.Parameters.Add(new MySqlParameter("@" + pNamesOut[i], MySqlDbType.Int32));
        //        cmd.Parameters["@" + pNamesOut[i]].Direction = ParameterDirection.Output;
        //    }

        //    EstablecerConexion();
        //    cmd.ExecuteNonQuery();

        //    List<object> salidaPA = new List<object>();

        //    for (int i = 0; i < pNamesOut.Count; i++)
        //    {
        //        salidaPA.Add(cmd.Parameters["@" + pNamesOut[i]].Value);
        //    }

        //    CerrarConexion();

        //    return salidaPA;

        //}
    }

}
