using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
    public class publisherFactory
    {
        publisherAccessClass objPublisherAccessClass;

        public publisherFactory()
        {
            objPublisherAccessClass = new publisherAccessClass();
        }

        public bool insert(PPUBLISHER tobjPublisher)
        {
            return objPublisherAccessClass.insert(tobjPublisher);
        }

        public List<PPUBLISHER> getAllPublishers()
        {
            return objPublisherAccessClass.viewAllPublishers();
        }

        public List<PPUBLISHER> getAllPublishersById(int iD)
        {
            return objPublisherAccessClass.searchPublisherById(iD);
        }

        public bool delete(int iD)
        {
            return objPublisherAccessClass.delete(iD);
        }

        public bool update(int id, string pubName, string pubContact)
        {
            return objPublisherAccessClass.update(id, pubName, pubContact);
        }
    }
}

