using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbRackAccessClass
    {
        PRO_DBEntities objLmsDbConext;

        public cmbRackAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<RACK> SelectAllEntries()
        {
            return objLmsDbConext.RACKs.ToList();
        }
    }

}
