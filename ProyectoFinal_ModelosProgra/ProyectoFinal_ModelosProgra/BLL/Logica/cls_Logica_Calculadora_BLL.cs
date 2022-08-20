using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.Variables;



namespace BLL.Logica
{
    public class cls_Logica_Calculadora_BLL
    {
        cls_Variables_Calculadora_DAL ObjDAL = new cls_Variables_Calculadora_DAL();

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
