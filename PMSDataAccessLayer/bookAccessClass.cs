using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class bookAccessClass
    {
        PRO_DBEntities objLmsDbContext;

        public bookAccessClass()
        {
            objLmsDbContext = new PRO_DBEntities();
        }

        public bool insert(PROD tobjBook)
        {
            objLmsDbContext.PRODs.Add(tobjBook);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<PROD> viewAllBooks()
        {
            return objLmsDbContext.PRODs.ToList();
        }


        public List<PROD> searchBookById(int id)
        {
            return (from c in objLmsDbContext.PRODs
                    where c.bookId == id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            PROD ObjBookTable = objLmsDbContext.PRODs.Where(x => x.bookId == id).FirstOrDefault();

            if (ObjBookTable != null)
            {
                objLmsDbContext.PRODs.Remove(ObjBookTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }

        public bool update(int id, string bkName, int bkPrice)
        {
            PROD ObjBookTable = objLmsDbContext.PRODs.Where(x => x.bookId == id).FirstOrDefault();
            if (ObjBookTable != null)
            {
                ObjBookTable.bookName = bkName;
                ObjBookTable.purchasePrice = bkPrice;
            }

            return objLmsDbContext.SaveChanges() > 0;
        }


    }
}

