using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMSDataAccessLayer
{
   public class publisherAccessClass
    {
        PRO_DBEntities objLmsDbContext;

        public publisherAccessClass()
        {
            objLmsDbContext = new PRO_DBEntities();
        }
        
        public bool insert(PPUBLISHER tobjPublisher)
        {
            objLmsDbContext.PPUBLISHERs.Add(tobjPublisher);
            return objLmsDbContext.SaveChanges() > 0;
        }

        public List<PPUBLISHER> viewAllPublishers()
        {
            return objLmsDbContext.PPUBLISHERs.ToList();
        }

        public List<PPUBLISHER> searchPublisherById(int id)
        {
            return (from c in objLmsDbContext.PPUBLISHERs
                    where c.publisherId == id
                    select c).ToList();
        }

        public bool delete(int id)
        {
            PPUBLISHER ObjPublisherTable = objLmsDbContext.PPUBLISHERs.Where(x => x.publisherId == id).FirstOrDefault();

            if (ObjPublisherTable != null)
            {
                objLmsDbContext.PPUBLISHERs.Remove(ObjPublisherTable);
            }

            return objLmsDbContext.SaveChanges() > 0;
        }
        public bool update(int id, string publName, string publContact)
        {
            PPUBLISHER ObjPublisherTable = objLmsDbContext.PPUBLISHERs.Where(x => x.publisherId == id).FirstOrDefault();
            if (ObjPublisherTable != null)
            {
                ObjPublisherTable.publisherName = publName;
                ObjPublisherTable.publisherContact = publContact;
            }

            return objLmsDbContext.SaveChanges() > 0;

        }

    }
}
