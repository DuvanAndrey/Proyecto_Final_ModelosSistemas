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


namespace BLL.Logica
{
    public class cls_Logica_Validador_BLL
    {


        public void Correo(cls_Variables_Validador_DAL ObjDAL2)
        {
            if (Regex.IsMatch(ObjDAL2.sFrase, @"^[a-zA-Z0-9_]+([a-zA-Z0-9_.]+)*@[a-zA-Z0-9_]+([.][a-zA-Z0-9_]+)*.[a-zA-Z]{2,5}+$"))
            {
               
                ObjDAL2.sMsj = "Transacción correcta";
            }
            else
            {
                
            }

        }

    }
}
