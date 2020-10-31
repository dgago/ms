using System;
using System.Linq;

namespace ef
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new TestContext())
            {
                // Create
                Console.WriteLine("Inserting a new customer");
                db.Add(new Customer { Name = "Lionel Messi" });
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a customer");
                var customer = db.Customers
                    .OrderBy(b => b.CustomerId)
                    .First();

                // Update
                Console.WriteLine("Updating the customer and adding an address");
                customer.Name = "Lionel Andrés Messi";
                customer.Address =
                    new Address
                    {
                        AddressLine1 = "Calle 1",
                        AddressLine2 = "Centro"
                    };
                db.SaveChanges();

                // Delete
                Console.WriteLine("Delete the customer");
                db.Remove(customer);
                db.SaveChanges();
            }
        }
    }
}
