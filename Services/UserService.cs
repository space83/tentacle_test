using WebApplication2.DBContexts;

namespace WebApplication2.Services
{
    public static class UserService
    {
        public static bool InsertUser(CdnUser user)
        {
            using (var ctx = Common.CreateContext())
            {
                try
                {
                    ctx.CdnUsers.Add(user);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }

        public static List<CdnUser> GetUsers()
        {
            using (var ctx = Common.CreateContext())
            {
                try
                {
                    return ctx.CdnUsers.ToList();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }           
        }

        public static bool UpdateUser(CdnUser user)
        {
            using (var ctx = Common.CreateContext())
            {
                try
                {
                    ctx.CdnUsers.Update(user);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }

        public static bool DeleteUser(Guid userid)
        {
            using (var ctx = Common.CreateContext())
            {
                try
                {
                    var deleteuser = ctx.CdnUsers.Where(x => x.Id == userid).SingleOrDefault();
                    ctx.CdnUsers.Remove(deleteuser);
                    ctx.SaveChanges();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
