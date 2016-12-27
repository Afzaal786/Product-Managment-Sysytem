using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class cmbMemberFactory
    {
        cmbMemberAccessClass objCmbMemberAccessClass;

        public cmbMemberFactory()
        {
            objCmbMemberAccessClass = new cmbMemberAccessClass();
        }

        public List<MEMBER> getAllEntries()
        {
            return objCmbMemberAccessClass.SelectAllEntries();
        }
    }

}
