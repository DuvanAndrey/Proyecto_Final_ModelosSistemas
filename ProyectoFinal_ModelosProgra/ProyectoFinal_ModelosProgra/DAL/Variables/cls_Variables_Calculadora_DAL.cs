using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Variables
{
    public class cls_Variables_Calculadora_DAL
    {
        string valor1, valor2, Resultado;

        #region VARIABLES PRIVADAS


        private string _sAX,
                       _sCadena,
                       _sMsj_Error,
                       _sSetencia,
                       _sNombreTabla;


        private bool _bEstAX;

        public string sCadena
        {
            get
            {
                return _sCadena;
            }

            set
            {
                _sCadena = value;
            }
        }

        public string sAX
        {
            get
            {
                return _sAX;
            }

            set
            {
                _sAX = value;
            }
        }

        public bool bEstAX
        {
            get
            {
                return _bEstAX;
            }

            set
            {
                _bEstAX = value;
            }
        }

        public string sMsj_Error
        {
            get
            {
                return _sMsj_Error;
            }

            set
            {
                _sMsj_Error = value;
            }
        }

        public string sSetencia
        {
            get
            {
                return _sSetencia;
            }

            set
            {
                _sSetencia = value;
            }
        }

        public string sNombreTabla
        {
            get
            {
                return _sNombreTabla;
            }

            set
            {
                _sNombreTabla = value;
            }
        }

        public SqlConnection Obj_Sql_cnx;

        public SqlCommand Obj_Sql_Cmd;

        public SqlDataAdapter Obj_Sql_Dap;

        public System.Data.DataSet Ds = new System.Data.DataSet();

        public System.Data.DataTable dt_PARAMETROS = new System.Data.DataTable("PARAMETROS");


        public string Valor1 { get => valor1; set => valor1 = value; }
        public string Valor2 { get => valor2; set => valor2 = value; }
        public string Resultado1 { get => Resultado; set => Resultado = value; }

    }

    #endregion
}
