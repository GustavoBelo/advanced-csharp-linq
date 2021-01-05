using System;

namespace Linq.Samples.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public CategoryType Type { get; set; }
    }
}
