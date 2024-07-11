using System.ComponentModel.DataAnnotations.Schema;

namespace EfCore.CodeFirst.DAL;

[Table("ProductTb",Schema ="products")] //tablonun ismini farklı bir isim girdik. EfCore Products yerine ProductTb yapacak
public class Product
{
    [Column(Order =1)]
    public int Id { get; set; }

    [Column("name2",Order = 2)]
    public string Name { get; set; }
    
    [Column("price2",Order = 3,TypeName ="decimal(18,2)")]
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public DateTime? CreatedDate { get; set; }
    public int Barcode { get; set; }
}
