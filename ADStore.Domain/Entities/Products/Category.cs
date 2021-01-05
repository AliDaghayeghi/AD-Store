using ADStore.Domain.Entities.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADStore.Domain.Entities.Products
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual Category ParentCategory { get; set; }
        public long? ParentCategoryId { get; set; }


        //برای نمایش زیر دسته های هر گروه
        public virtual ICollection<Category> SubCategories { get; set; }

    }
}
