using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class bookIssuenceFactory
    {
        bookIssuenceAccessClass objBookIssuence;

        public bookIssuenceFactory()
        {
            objBookIssuence = new bookIssuenceAccessClass();
        }

        public bool insert(PRO_ISSUENCE tobjBookIssuence)
        {
            return objBookIssuence.insert(tobjBookIssuence);
        }

        public List<PRO_ISSUENCE> getAllIssuedBooks()
        {
            return objBookIssuence.viewAllBooksIssued();
        }

        public List<PRO_ISSUENCE> getAllIssuedBooksById(int iD)
        {
            return objBookIssuence.searchIssuedBookById(iD);
        }

        public bool delete(int iD)
        {
            return objBookIssuence.delete(iD);
        }

        public bool update(int id, DateTime IssuedOn, DateTime returndOn)
        {
            return objBookIssuence.update(id, IssuedOn, returndOn);
        }

    
}
}
