using System.Data;
using Dapper;

namespace Store_Dapper.SeedData
{
    public class Seed
    {
         public static async Task Create(IDbConnection connection)
        {
            using (var transaction = connection.BeginTransaction())
            {

                var categoryId = await connection.ExecuteScalarAsync<int>("insert into categories(name) values('telefonlar') returning id");



                var command = "insert into books(name,price,stock)values(@name,@price,@stock) returning id";
                var command2 = "insert into customers(name,lastname,balance)values(@name,@lastname,@balance) returning id";

                await connection.ExecuteScalarAsync<int>(command, new { name = "Anna Karenina", price = 10, stock = 100});
                await connection.ExecuteScalarAsync<int>(command, new { name = "The Odyssey ", price = 59, stock = 75});
                await connection.ExecuteScalarAsync<int>(command, new { name = "Moby Dick", price = 35, stock = 22});
                  await connection.ExecuteScalarAsync<int>(command, new { name = "Nutuk ", price = 25, stock = 1000});
                await connection.ExecuteScalarAsync<int>(command, new { name = "The Godfather", price = 500, stock = 502});

                await connection.ExecuteScalarAsync<int>(command2, new { name = "Margot",lastname="Robbie",balance = 760});
                await connection.ExecuteScalarAsync<int>(command2, new { name = "Joey", lastname="Tribbiani",balance =350});
                await connection.ExecuteScalarAsync<int>(command2, new { name = "Ross", lastname="Geller",balance =2432});


                transaction.Commit();
            }
        }
    }
}