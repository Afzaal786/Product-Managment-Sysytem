using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class authorAccessClass
    {

        
        PRO_DBEntities objLmsDbContext;

        public authorAccessClass()
        {
            objLmsDbContext = new PRO_DBEntities();
        }

        public bool insert(MANU tobjAuthor)
        {
            objLmsDbContext.MANUs.Add(tobjAuthor);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<MANU> viewAllAuthors()
        {
            return objLmsDbContext.MANUs.ToList();
        }

        public List<MANU> searchAuthorById(int id)
        {
            return (from c in objLmsDbContext.MANUs
                    where c.authorId == id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            MANU ObjAuthorTable = objLmsDbContext.MANUs.Where(x => x.authorId == id).FirstOrDefault();

            if (ObjAuthorTable != null)
            {
                objLmsDbContext.MANUs.Remove(ObjAuthorTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, string authName, string authContact)
        {
            MANU ObjAuthorTable = objLmsDbContext.MANUs.Where(x => x.authorId == id).FirstOrDefault();
            if (ObjAuthorTable != null)
            {
                ObjAuthorTable.authorName = authName;
                ObjAuthorTable.authorContact = authContact;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }
    
}
}
