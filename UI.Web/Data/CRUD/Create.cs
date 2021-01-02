using UI.Web.Data.Entities.PROD;

namespace UI.Web.Data.CRUD
{
    public class Create
    {
        public static void Entity(dynamic entity)
        {
            using var context = new zorrarth_archiveContext();
            context.SiteVisits.Add(entity);
            context.SaveChanges();
        }
    }
}