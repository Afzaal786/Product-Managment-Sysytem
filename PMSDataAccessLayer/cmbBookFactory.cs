using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbBookFactory
    {
        cmbBookAccessClass objCmbBookAccessClass;

        public cmbBookFactory()
        {
            objCmbBookAccessClass = new cmbBookAccessClass();
        }

        public List<PROD> getAllEntries()
        {
            return objCmbBookAccessClass.SelectAllEntries();
        }
    }
}
