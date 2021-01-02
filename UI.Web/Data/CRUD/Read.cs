using System;
using System.Collections.Generic;
using System.Linq;
using UI.Web.Data.Entities.PROD;

namespace UI.Web.Data.CRUD
{
    public class Read
    {
        //public static Tuple<List<dynamic>, List<dynamic>> ReadTuple(string email)
        //{
        //    using var context1 = new zorrarth_archiveContext();
        //    var c = context1.P4hCreators.Where(z => z.Email == email).ToList();

        //    using var context2 = new zorrarth_archiveContext();
        //    var cd = context2.P4hProjects.Where(z => z.IdGuid == c[0].IdGuid).ToList();

        //    return Tuple.Create(c, cd);
        //}

        public static dynamic Single(int id)
        {
            using var context = new zorrarth_archiveContext();
            return context.SiteVisits.Where(z => z.Id == id).ToList();
        }
    }
}