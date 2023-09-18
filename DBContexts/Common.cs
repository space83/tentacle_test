using Microsoft.EntityFrameworkCore;

namespace WebApplication2.DBContexts
{
    public static class Common
    {
        public static string connectionstring = "";
        //wheter to dump the EF statements or not
        public static bool enableEFlog = false;

        public static CdndbContext CreateContext()
        {
            var optionsBuilder = new DbContextOptionsBuilder<CdndbContext>();

            optionsBuilder.UseSqlServer(connectionstring);

            return new CdndbContext(optionsBuilder.Options);
        }


    }
}
