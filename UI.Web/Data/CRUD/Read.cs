using System.Linq;
using UI.Web.Data.Entities.PROD;

namespace UI.Web.Data.CRUD
{
    public class Read
    {
        public static dynamic Single(int id)
        {
            using var context = new zorrarth_archiveContext();
            return context.SiteVisits.Where(z => z.Id == id).ToList();
        }
    }
}