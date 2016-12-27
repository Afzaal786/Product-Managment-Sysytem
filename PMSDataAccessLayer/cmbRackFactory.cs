using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbRackFactory
    {
        cmbRackAccessClass objCmbRackAccessClass;

        public cmbRackFactory()
        {
            objCmbRackAccessClass = new cmbRackAccessClass();
        }

        public List<RACK> getAllEntries()
        {
            return objCmbRackAccessClass.SelectAllEntries();
        }
    }
}

