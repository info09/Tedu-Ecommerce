using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TeduEcommerce.Products;

namespace TeduEcommerce.Configurations.Products
{
    public class ProductAttributeVarcharConfiguration : IEntityTypeConfiguration<ProductAttributeVarchar>
    {
        public void Configure(EntityTypeBuilder<ProductAttributeVarchar> builder)
        {
            builder.ToTable(TeduEcommerceConsts.DbTablePrefix + "ProductAttributeVarchars");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Value).HasMaxLength(500);
        }
    }
}