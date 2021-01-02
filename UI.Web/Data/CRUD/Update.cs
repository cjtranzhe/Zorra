using System;
using System.Linq;
using System.Threading.Tasks;
using UI.Web.Data.Entities.PROD;

namespace UI.Web.Data.CRUD
{
    public class Update
    {
        //public static async Task asyncUpdate(int id)
        //{
        //    using var context = new zorrarth_archiveContext();
        //    var query = from t in context.SiteVisits
        //                where t.Id == id
        //                select t;

        //    foreach (var item in query)
        //    {
        //        item.DateCreated = DateTime.Now;
        //    }

        //    await context.SaveChangesAsync();
        //}

        public static void Entity(int id)
        {
            using var context = new zorrarth_archiveContext();
            var query = from t in context.SiteVisits
                        where t.Id == id
                        select t;

            foreach (var item in query)
            {
                item.DateCreated = null;
            }

            //context.SaveChanges();
        }
    }
}