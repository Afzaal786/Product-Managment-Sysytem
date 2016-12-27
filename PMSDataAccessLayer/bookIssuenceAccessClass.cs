using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class bookIssuenceAccessClass
    {
        PRO_DBEntities objLmsDbContext;

        public bookIssuenceAccessClass()
        {
            objLmsDbContext = new PRO_DBEntities();
        }

        public bool insert(PRO_ISSUENCE tobjBookIssuence)
        {
            objLmsDbContext.PRO_ISSUENCE.Add(tobjBookIssuence);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<PRO_ISSUENCE> viewAllBooksIssued()
        {
            return objLmsDbContext.PRO_ISSUENCE.ToList();
        }

        public List<PRO_ISSUENCE> searchIssuedBookById(int id)
        {
            return (from c in objLmsDbContext.PRO_ISSUENCE
                    where c.issueId == id
                    select c).ToList();
        }
        public bool delete(int id)
        {
            PRO_ISSUENCE ObjBITable = objLmsDbContext.PRO_ISSUENCE.Where(x => x.issueId == id).FirstOrDefault();

            if (ObjBITable != null)
            {
                objLmsDbContext.PRO_ISSUENCE.Remove(ObjBITable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, DateTime IssuedOn, DateTime returndOn)
        {
            PRO_ISSUENCE ObjBITable = objLmsDbContext.PRO_ISSUENCE.Where(x => x.issueId == id).FirstOrDefault();
            if (ObjBITable != null)
            {
                ObjBITable.issueOn = IssuedOn;
                ObjBITable.returnDate = returndOn;

            }
            return objLmsDbContext.SaveChanges() > 0;
        }
    }

}
