using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace SQLite;

public class Category
{
	[Key]
	public int Category { get; set; }
	
	[Required]
	[stringLeng(15)]
	public string Category { get; set; } = null;
	
	[Column(TypeName = "ntext")]
	public string? Description { get; set; }
	public virtual ICollection<Product> Products { get; set; }
	
	public Category()
	{
		Products = new HashSet<Product>();
	}
}
