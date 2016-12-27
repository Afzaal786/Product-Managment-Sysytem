using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbBookAccessClass
    {
        PRO_DBEntities objLmsDbConext;

        public cmbBookAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<PROD> SelectAllEntries()
        {
            return objLmsDbConext.PRODs.ToList();
        }
    }
}
