using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Variables;
using BLL.DB;
using DAL.BD;


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

        public void Sumar(cls_Variables_Calculadora_DAL ObjDAL)
        {
            double x, y;

            x = Convert.ToInt32(ObjDAL.Valor1);
            y = Convert.ToInt32(ObjDAL.Valor2);

            ObjDAL.Resultado1 = Convert.ToString(x + y);

        }

        public void Restar(cls_Variables_Calculadora_DAL ObjDAL)
        {
            double x, y;

            x = Convert.ToInt32(ObjDAL.Valor1);
            y = Convert.ToInt32(ObjDAL.Valor2);

            ObjDAL.Resultado1 = Convert.ToString(x - y);

        }

        public void Multiplicar(cls_Variables_Calculadora_DAL ObjDAL)
        {
            double x, y;

            x = Convert.ToInt32(ObjDAL.Valor1);
            y = Convert.ToInt32(ObjDAL.Valor2);

            ObjDAL.Resultado1 = Convert.ToString(x * y);

        }

        public void Division(cls_Variables_Calculadora_DAL ObjDAL)
        {
            double x, y;

            x = Convert.ToInt32(ObjDAL.Valor1);
            y = Convert.ToInt32(ObjDAL.Valor2);

            ObjDAL.Resultado1 = Convert.ToString(x / y);

        }

    }
}
