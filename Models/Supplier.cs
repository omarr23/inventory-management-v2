using System.ComponentModel.DataAnnotations;

public class Supplier
{
    [Key]
    public int SupplierId { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    public string Address { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<SupplierProduct> SupplierProducts { get; set; } = new List<SupplierProduct>();
}
