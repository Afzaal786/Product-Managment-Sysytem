using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbPublisherAccessClass
    {
        PRO_DBEntities objLmsDbConext;

        public cmbPublisherAccessClass()
        {
            objLmsDbConext = new PRO_DBEntities();
        }

        public List<PPUBLISHER> SelectAllEntries()
        {
            return objLmsDbConext.PPUBLISHERs.ToList();
        }
    
}
}
