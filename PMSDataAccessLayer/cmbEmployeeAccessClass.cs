using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbEmployeeAccessClass
    {
        PRO_DBEntities objLmsDbConext;

        public cmbEmployeeAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<EMPLOYEE> SelectAllEntries()
        {
            return objLmsDbConext.EMPLOYEEs.ToList();
        }
    }
}
