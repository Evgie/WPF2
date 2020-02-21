using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Task2_2.Models;

namespace Task2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new zzaContext())
            {
                //
                //Eager.
                //
                //var products = context.Product
                //    .Where(p => p.Name == "Cola")
                //    .Include(p => p.OrderItem)
                //    .ThenInclude(o => o.Order)
                //    .ToList();

                //
                //Explicit.
                //
                //var order = context.OrderItem
                //    .Where(orderI => orderI.ProductId == 3)
                //    .FirstOrDefault();
                //var orders = context.Entry(order).Reference(o => o.Order)
                //    .Query()
                //    .Select(o => new
                //    {
                //        OrderDate = o.OrderDate,
                //        Phone = o.Phone
                //    });

                //
                //Lazy.
                //
                var order = context.Order.FirstOrDefault();

            }
        }
    }
}
