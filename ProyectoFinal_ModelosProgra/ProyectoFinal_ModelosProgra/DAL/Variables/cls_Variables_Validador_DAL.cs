using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Variables
{
    public class cls_Variables_Validador_DAL
    {

        #region variables

        string _sFrase, _sMsj;

  
        #endregion

        #region constructores
        public string sFrase { get => _sFrase; set => _sFrase = value; }
        public string sMsj { get => _sMsj; set => _sMsj = value; }
        #endregion
    }
}
