using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.BD;

namespace BLL.DB
{
    public class Cls_BD_BLL
    {
        public void Traer_Cnx(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                obj_BD_DAL.sCadena = ConfigurationManager.ConnectionStrings["SQL_AUT"].ToString();

                obj_BD_DAL.SQL_CNX = new SqlConnection(obj_BD_DAL.sCadena);

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (Exception e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
        }


        public void Abrir_Cnx(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Closed)
                {
                    obj_BD_DAL.SQL_CNX.Open();
                }

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
        }


        public void Exec_DataAdapter(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                Traer_Cnx(ref obj_BD_DAL);

                if ((obj_BD_DAL.sMsjError == string.Empty) && (obj_BD_DAL.bBandError == false))
                {
                    Abrir_Cnx(ref obj_BD_DAL);


                    obj_BD_DAL.SQL_DA = new SqlDataAdapter(obj_BD_DAL.sSentencia, obj_BD_DAL.SQL_CNX);

                    #region Valido si hay o no parametros, para agregarlos

                    obj_BD_DAL.SQL_DA.SelectCommand.CommandType = CommandType.StoredProcedure;

                    if (obj_BD_DAL.Dt_Parametros.Rows.Count > 0)
                    {

                        foreach (DataRow dr in obj_BD_DAL.Dt_Parametros.Rows)
                        {
                            switch (dr["TipoDatoParam"].ToString())
                            {
                                case "1":
                                    {
                                        //agregamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.Int).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "2":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.NVarChar).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "3":
                                    {
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.Char).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "4":
                                    {
                                        obj_BD_DAL.SQL_DA.SelectCommand.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.VarChar).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }

                    #endregion

                    obj_BD_DAL.DS = new System.Data.DataSet();
                    obj_BD_DAL.SQL_DA.Fill(obj_BD_DAL.DS, obj_BD_DAL.sNomTabla);
                }

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
            finally
            {
                if (obj_BD_DAL != null)
                {
                    if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        obj_BD_DAL.SQL_CNX.Close();
                    }
                    //destruyo el objeto
                    obj_BD_DAL.SQL_CNX.Dispose();
                }
            }
        }


        public void Exec_NonQuery(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                Traer_Cnx(ref obj_BD_DAL);

                if ((obj_BD_DAL.sMsjError == string.Empty) && (obj_BD_DAL.bBandError == false))
                {
                    Abrir_Cnx(ref obj_BD_DAL);

                    obj_BD_DAL.SQL_CMD = new SqlCommand(obj_BD_DAL.sSentencia, obj_BD_DAL.SQL_CNX);

                    #region Valido si hay o no parametros, para agregarlos

                    obj_BD_DAL.SQL_CMD.CommandType = CommandType.StoredProcedure;

                    if (obj_BD_DAL.Dt_Parametros.Rows.Count > 0)
                    {

                        foreach (DataRow dr in obj_BD_DAL.Dt_Parametros.Rows)
                        {
                            switch (dr["TipoDatoParam"].ToString())
                            {
                                case "1":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.Int).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "2":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.NVarChar).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "3":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.Char).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "4":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(), SqlDbType.VarChar).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }

                    #endregion

                    obj_BD_DAL.SQL_CMD.ExecuteNonQuery();
                }

                obj_BD_DAL.sMsjError = string.Empty;
                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
            finally
            {
                if (obj_BD_DAL != null)
                {
                    if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        obj_BD_DAL.SQL_CNX.Close();
                    }
                    //destruyo el objeto
                    obj_BD_DAL.SQL_CNX.Dispose();
                }
            }
        }


        public void Exec_Scalar(ref Cls_BD_DAL obj_BD_DAL)
        {
            try
            {
                Traer_Cnx(ref obj_BD_DAL);

                if ((obj_BD_DAL.sMsjError == string.Empty) && (obj_BD_DAL.bBandError == false))
                {
                    Abrir_Cnx(ref obj_BD_DAL);

                    obj_BD_DAL.SQL_CMD = new SqlCommand(obj_BD_DAL.sSentencia, obj_BD_DAL.SQL_CNX);

                    #region Valido si hay o no parametros, para agregarlos

                    obj_BD_DAL.SQL_CMD.CommandType = CommandType.StoredProcedure;

                    if (obj_BD_DAL.Dt_Parametros.Rows.Count > 0)
                    {

                        foreach (DataRow dr in obj_BD_DAL.Dt_Parametros.Rows)
                        {
                            switch (dr["TipoDatoParam"].ToString())
                            {
                                case "1":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.Int).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "2":
                                    {
                                        //agreagamos parametros que va a consumir mi store procedure 
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.NVarChar).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "3":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(),
                                                                                       SqlDbType.Char).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                case "4":
                                    {
                                        obj_BD_DAL.SQL_CMD.Parameters.Add(dr["NombreParam"].ToString(), SqlDbType.VarChar).Value = dr["ValorParam"].ToString();
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }
                        }
                    }

                    #endregion

                    obj_BD_DAL.sValorScalar = obj_BD_DAL.SQL_CMD.ExecuteScalar().ToString();
                }

                obj_BD_DAL.sMsjError = string.Empty;

                obj_BD_DAL.bBandError = false;
            }
            catch (SqlException e)
            {
                obj_BD_DAL.sValorScalar = "";
                obj_BD_DAL.sMsjError = e.Message.ToString();
                obj_BD_DAL.bBandError = true;
            }
            finally
            {
                if (obj_BD_DAL != null)
                {
                    if (obj_BD_DAL.SQL_CNX.State == System.Data.ConnectionState.Open)
                    {
                        obj_BD_DAL.SQL_CNX.Close();
                    }
                    //destruyo el objeto
                    obj_BD_DAL.SQL_CNX.Dispose();
                }
            }
        }


        public void Crear_DT_Parametros(ref Cls_BD_DAL Obj_BD_DAL)
        {
            Obj_BD_DAL.Dt_Parametros = new DataTable("Parametros");
            Obj_BD_DAL.Dt_Parametros.Columns.Add("NombreParam");
            Obj_BD_DAL.Dt_Parametros.Columns.Add("TipoDatoParam");
            Obj_BD_DAL.Dt_Parametros.Columns.Add("ValorParam");
        }
    }
}
