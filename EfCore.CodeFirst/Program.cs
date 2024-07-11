using EfCore.CodeFirst;
using EfCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

Initializer.Build();

using (var context = new AppDbContext())
{

    //await context.Products.AddAsync(new Product { Name = "Kalem 1",Price = 200,Stock = 100, Barcode = 123});
    //await context.Products.AddAsync(new Product { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });
    //await context.Products.AddAsync(new Product { Name = "Kalem 1", Price = 200, Stock = 100, Barcode = 123 });

    var products = await context.Products.AsNoTracking().ToListAsync(); //AsNoTracking() verinin memory'de track edilmemesini sağlıyor. bu sayade memory dolmuyor.

    Console.WriteLine($"context id: {context.ContextId}");
  




    //var newProduct = new Product { Name = "Kitap", Price = 55, Barcode = 145, Stock = 6 };
    
    //var product = await context.Products.FirstAsync();  //First methodu veritabanında karşılaştığı ilk datayı verir

    //await context.AddAsync(newProduct); //veya => context.Entry(newProduct).State = EntityState.Added;  <= ikisi de aynı şeyi yapıyor.
    //Console.WriteLine("ilk state: " + context.Entry(product).State);

    //context.Remove(product);
    //Console.WriteLine("silme işlemi state: " + context.Entry(product).State);
    //await context.SaveChangesAsync();
    //Console.WriteLine("son state: " + context.Entry(product).State);
    
    //var products = await context.Products.ToListAsync();
    //products.ForEach(p=>{
    //    var state = context.Entry(p).State;   //p içindeki state i verir.

    //    Console.WriteLine($"{p.Id}: {p.Name} - {p.Price} - {p.Barcode} - {p.Stock} | state: {state}");
    //});
}

Console.WriteLine("Hello, World!");
