﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class bookFactory
    {
        bookAccessClass objBookAccessClass;

        public bookFactory()
        {
            objBookAccessClass = new bookAccessClass();
        }

        public bool insert(PROD tobjBook)
        {
            return objBookAccessClass.insert(tobjBook);
        }

        public List<PROD> getAllBooks()
        {
            return objBookAccessClass.viewAllBooks();
        }

        public List<PROD> getAllBooksById(int id)
        {
            return objBookAccessClass.searchBookById(id);
        }

        public bool delete(int iD)
        {
            return objBookAccessClass.delete(iD);
        }

        public bool update(int id, string bokName, int bokPrice)
        {
            return objBookAccessClass.update(id, bokName, bokPrice);
        }



    }
}
