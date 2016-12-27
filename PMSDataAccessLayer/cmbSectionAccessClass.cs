using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbSectionAccessClass
    {
        PRO_DBEntities objLmsDbConext;

        public cmbSectionAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<SECTION> SelectAllEntries()
        {
            return objLmsDbConext.SECTIONs.ToList();
        }
    
}
}
