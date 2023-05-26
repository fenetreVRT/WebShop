using System.ComponentModel.DataAnnotations.Schema;

namespace WebShop.Models.Entities;

public class ProductEntity
{

    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Image { get; set; }
    public required string Description { get; set; }

    [Column(TypeName = "money")]
    public decimal Price { get; set; }

    public ICollection<TagEntity> Tags { get; set; } = new HashSet<TagEntity>();
}
