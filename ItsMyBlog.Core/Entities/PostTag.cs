using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItsMyBlog.Data.Entities
{
    public class PostTag
    {
        public PostTag()
        {
            Post = new Post();
            Tag = new Tag();
        }

        public int Id { get; set; }
        public virtual Post Post { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
