using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Variables;
using BLL.DB;
using DAL.BD;
using System.Text.RegularExpressions;
using System.IO;

namespace BLL.Logica
{
    public class cls_Logica_Calculadora_BLL
    {
        Cls_BD_BLL Obj_BD_BLL = new Cls_BD_BLL();
        Cls_BD_DAL Obj_BD_DAL = new Cls_BD_DAL();     

        public void ListarRegistro(ref cls_Variables_Calculadora_DAL ObjDAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sNomTabla = "REGISTRO";
            Obj_BD_DAL.sSentencia = "dbo.SpListarRegistros";

            Obj_BD_BLL.Exec_DataAdapter(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                ObjDAL.sMsj_Error = string.Empty;
                ObjDAL.dt_PARAMETROS = Obj_BD_DAL.DS.Tables["REGISTRO"];
            }
            else
            {
                ObjDAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                ObjDAL.dt_PARAMETROS = null;
            }
        }

        public void InsertarRegistro(ref cls_Variables_Calculadora_DAL ObjDAL)
        {
            Obj_BD_DAL = new Cls_BD_DAL();

            Obj_BD_DAL.sSentencia = "dbo.SpInsertarRegistros";

            Obj_BD_BLL.Crear_DT_Parametros(ref Obj_BD_DAL);
            Obj_BD_DAL.Dt_Parametros.Rows.Add(@"@Expresion1", "4", ObjDAL.Valor1);
            Obj_BD_DAL.Dt_Parametros.Rows.Add(@"@Operador", "4", ObjDAL.Operador1);
            Obj_BD_DAL.Dt_Parametros.Rows.Add(@"@Expresion2", "4", ObjDAL.Valor2);
            Obj_BD_DAL.Dt_Parametros.Rows.Add(@"@Resultado", "4", ObjDAL.Resultado1);
            Obj_BD_DAL.Dt_Parametros.Rows.Add(@"@Observaciones", "4", ObjDAL.Observacion1);

            Obj_BD_BLL.Exec_Scalar(ref Obj_BD_DAL);

            if (Obj_BD_DAL.sMsjError == string.Empty)
            {
                ObjDAL.sMsj_Error = string.Empty;
                ObjDAL.IdRegistro = Convert.ToInt32(Obj_BD_DAL.sValorScalar);
                ObjDAL.sAX = "U";
            }
            else
            {
                ObjDAL.sMsj_Error = Obj_BD_DAL.sMsjError;
                ObjDAL.sAX = "I";
            }
        }

        public void Sumar(cls_Variables_Calculadora_DAL ObjDAL)
        {
            if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
            {
                double x = 0;
                double y = 0;

                if (ObjDAL.Resultado1 == string.Empty)
                {
                    x = Convert.ToInt32(ObjDAL.Valor1);
                    y = Convert.ToInt32(ObjDAL.Valor2);
                    ObjDAL.Resultado1 = Convert.ToString(x + y);
                    ObjDAL.Observacion1 = "Transacción correcta";
                }
                else
                {
                    x = Convert.ToInt32(ObjDAL.Valor1);
                    y = Convert.ToInt32(ObjDAL.Valor2);
                    ObjDAL.Resultado1 = Convert.ToString((x + y) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "Transacción correcta";
                }
            }
            else
            {
                if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor1) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "B es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);

                }
                if (Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor2) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "A es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (!Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = ObjDAL.Resultado1;
                    ObjDAL.Observacion1 = "A & B son letras";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
            }
        }

        public void Restar(cls_Variables_Calculadora_DAL ObjDAL)
        {
            if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
            {
                double x = 0;
                double y = 0;

                if (ObjDAL.Resultado1 == string.Empty)
                {
                    x = Convert.ToInt32(ObjDAL.Valor1);
                    y = Convert.ToInt32(ObjDAL.Valor2);
                    ObjDAL.Resultado1 = Convert.ToString(x - y);
                    ObjDAL.Observacion1 = "Transacción correcta";
                }
                else
                {
                    x = Convert.ToInt32(ObjDAL.Valor1);
                    y = Convert.ToInt32(ObjDAL.Valor2);
                    ObjDAL.Resultado1 = Convert.ToString((x - y) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "Transacción correcta";
                }
            }
            else
            {
                if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor1) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "B es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor2) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "A es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (!Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = ObjDAL.Resultado1;
                    ObjDAL.Observacion1 = "A & B son letras";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
            }
        }

        public void Multiplicar(cls_Variables_Calculadora_DAL ObjDAL)
        {
            if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
            {
                double x = 0;
                double y = 0;

                if (ObjDAL.Resultado1 == string.Empty)
                {
                    x = Convert.ToInt32(ObjDAL.Valor1);
                    y = Convert.ToInt32(ObjDAL.Valor2);
                    ObjDAL.Resultado1 = Convert.ToString(x * y);
                    ObjDAL.Observacion1 = "Transacción correcta";
                }
                else
                {
                    x = Convert.ToInt32(ObjDAL.Valor1);
                    y = Convert.ToInt32(ObjDAL.Valor2);
                    ObjDAL.Resultado1 = Convert.ToString((x * y) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "Transacción correcta";
                }
            }
            else
            {
                if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor1) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "B es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor2) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "A es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (!Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = ObjDAL.Resultado1;
                    ObjDAL.Observacion1 = "A & B son letras";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
            }
        }

        public void Division(cls_Variables_Calculadora_DAL ObjDAL)
        {
            if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
            {
                double x, y;

                if (ObjDAL.Resultado1 == string.Empty)
                {

                    if (Convert.ToInt32(ObjDAL.Valor2) == 0)
                    {
                        ObjDAL.Observacion1 = "División entre 0.";
                        ObjDAL.Resultado1 = string.Empty;
                        SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                    }
                    else
                    {
                        x = Convert.ToInt32(ObjDAL.Valor1);
                        y = Convert.ToInt32(ObjDAL.Valor2);
                        ObjDAL.Resultado1 = Convert.ToString(x / y);
                        ObjDAL.Observacion1 = "Transacción correcta";
                    }
                }
                else
                {
                    if (Convert.ToInt32(ObjDAL.Valor2) == 0)
                    {
                        ObjDAL.Observacion1 = "División entre 0.";
                        ObjDAL.Resultado1 = ObjDAL.Resultado1;
                    }
                    else
                    {
                        x = Convert.ToInt32(ObjDAL.Valor1);
                        y = Convert.ToInt32(ObjDAL.Valor2);
                        ObjDAL.Resultado1 = Convert.ToString((x / y) + Convert.ToInt32(ObjDAL.Resultado1));
                        ObjDAL.Observacion1 = "Transacción correcta";
                    }
                }
            }
            else
            {
                if (Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor1) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "B es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = Convert.ToString(Convert.ToInt32(ObjDAL.Valor2) + Convert.ToInt32(ObjDAL.Resultado1));
                    ObjDAL.Observacion1 = "A es una letra";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
                if (!Regex.IsMatch(ObjDAL.Valor1, @"^[0-9]+$") && !Regex.IsMatch(ObjDAL.Valor2, @"^[0-9]+$"))
                {
                    ObjDAL.Resultado1 = ObjDAL.Resultado1;
                    ObjDAL.Observacion1 = "A & B son letras";
                    SaveError(Convert.ToString(ObjDAL.IdRegistro), ObjDAL.Valor1, ObjDAL.Operador1, ObjDAL.Valor2, ObjDAL.Resultado1, ObjDAL.Observacion1);
                }
            }
        }

        public void SaveError(string id, string exp1, string op, string exp2, string re, string obs)
        {
            string Msg = id + ";" + exp1 + ";" + op + ";" + exp2 + ";" + re + ";" + obs;

            //Save File to .txt  
            StreamWriter m_WriterParameter = new StreamWriter(@"C:\Users\SSequeira\Desktop\BitacoraErrores.txt", true);
            m_WriterParameter.BaseStream.Seek(0, SeekOrigin.End);
            m_WriterParameter.Write(Msg);
            m_WriterParameter.Write("\n");
            m_WriterParameter.Flush();
            m_WriterParameter.Close();
        }
    }          
}
    

