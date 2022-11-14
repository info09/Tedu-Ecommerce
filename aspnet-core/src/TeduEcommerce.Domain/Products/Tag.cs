using System;
using Volo.Abp.Domain.Entities;

namespace TeduEcommerce.Products
{
    public class Tag : Entity<Guid>
    {
        public string Name { get; set; }
    }
}
