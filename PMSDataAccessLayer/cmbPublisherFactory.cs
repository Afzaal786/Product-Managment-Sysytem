using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbPublisherFactory
    {
        cmbPublisherAccessClass objCmbPublisherAccessClass;

        public cmbPublisherFactory()
        {
            objCmbPublisherAccessClass = new cmbPublisherAccessClass();
        }

        public List<PPUBLISHER> getAllEntries()
        {
            return objCmbPublisherAccessClass.SelectAllEntries();
        }
    
}
}
