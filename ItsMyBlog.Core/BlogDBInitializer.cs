using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsMyBlog.Data
{
    public class BlogDBInitializer : CreateDatabaseIfNotExists<BlogDbContext>
    {
        public override void InitializeDatabase(BlogDbContext context)
        {
            base.InitializeDatabase(context);
        }
    }
}
