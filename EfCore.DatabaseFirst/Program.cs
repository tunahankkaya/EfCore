
using EfCore.DatabaseFirst.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build(); //bir defa initialize edilsin, app ayakta olduğu sürece tekrar edilmesine gerek yok.

using (var _context = new AppDbContext())
{
    var products = await _context.Products.ToListAsync();

    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name} - {p.Price}");
    });
}
