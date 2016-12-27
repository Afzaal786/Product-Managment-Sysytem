using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class authorFactory
    {
        authorAccessClass objAuthorAccessClass;

        public authorFactory()
        {
            objAuthorAccessClass = new authorAccessClass();
        }

        public bool insert(MANU tobjAuthor)
        {
            return objAuthorAccessClass.insert(tobjAuthor);
        }

        public List<MANU> getAllAuthors()
        {
            return objAuthorAccessClass.viewAllAuthors();
        }

        public List<MANU> getAllAuthorsById(int iD)
        {
            return objAuthorAccessClass.searchAuthorById(iD);
        }

        public bool delete(int iD)
        {
            return objAuthorAccessClass.delete(iD);
        }

        public bool update(int id, string autName, string autContact)
        {
            return objAuthorAccessClass.update(id, autName, autContact);
        }
    }
}
