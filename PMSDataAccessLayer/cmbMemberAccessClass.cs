using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbMemberAccessClass
    {
        PRO_DBEntities objLmsDbConext;
        public cmbMemberAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<MEMBER> SelectAllEntries()
        {
            return objLmsDbConext.MEMBERs.ToList();
        }
    }

}

