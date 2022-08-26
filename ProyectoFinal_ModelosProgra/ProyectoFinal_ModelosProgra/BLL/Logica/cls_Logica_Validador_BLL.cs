using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DAL.Variables;
using BLL.DB;
using DAL.BD;
using System.Text.RegularExpressions;
using System.Globalization;

namespace BLL.Logica
{
    public class cls_Logica_Validador_BLL
    {


        public void Correo(cls_Variables_Validador_DAL ObjDAL2)
        {
            if (Regex.IsMatch(ObjDAL2.sFrase, @"^[a-zA-Z0-9_]+([a-zA-Z0-9_.]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*.[a-zA-Z]{2,5}$"))
            {
                ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " CORRESPONDE A UN CORREO VÁLIDO.";
            }
            else
            {
                ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " NO CORRESPONDE A UN CORREO VÁLIDO.";
            }
        }

        public void Fecha(cls_Variables_Validador_DAL ObjDAL2)
        {
            if ((Regex.IsMatch(ObjDAL2.sFrase, @"^([0-9]{2,2}\/[0-9]{2,2}\/[0-9]{4,4}|[0-9]{2,2}\/[0-9]{2,2}\/[0-9]{2,2})$")))
            {
                DateTime date;

                bool fechaValida = DateTime.TryParseExact(
                ObjDAL2.sFrase,
                "dd/MM/yyyy",
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out date);

                if (fechaValida)
                {
                    ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " CORRESPONDE A UNA FECHA VÁLIDA.";
                }
                else {
                    ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " NO CORRESPONDE A UNA FECHA VÁLIDA.";
                }
            }
            else
            {
                ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " NO CORRESPONDE A UNA FECHA VÁLIDA.";
            }
        }

        public void ID(cls_Variables_Validador_DAL ObjDAL2)
        {
            if (Regex.IsMatch(ObjDAL2.sFrase, @"^([1-9]{1,1}[-]\d{4}[-]\d{4})+$"))
            {

                ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " CORRESPONDE A UNA CÉDULA VÁLIDA.";
            }
            else
            {
                ObjDAL2.sMsj = "EL FORMATO: " + ObjDAL2.sFrase + " NO CORRESPONDE A UNA CÉDULA VÁLIDA.";
            }

        }
    }
}
