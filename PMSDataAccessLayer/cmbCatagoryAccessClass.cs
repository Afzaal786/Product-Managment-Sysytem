using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbCatagoryAccessClass
    {
        PRO_DBEntities objLmsDbConext;

        public cmbCatagoryAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<CATAGORY> SelectAllEntries()
        {
            return objLmsDbConext.CATAGORies.ToList();
        }
   
}
}
