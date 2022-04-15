using System.Data;
using System.Reflection;
using FluentValidation.AspNetCore;
using MediatR;
using Npgsql;
using Store_Dapper.Repositores;
using Store_Dapper.SeedData;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//option.Filters.Add(new ValidateFilter()))
builder.Services.AddControllers().AddFluentValidation(x => x.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly()));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



//DI Container
// builder.Services.AddScoped<NotFoundProductFilter>();



builder.Services.AddScoped<IDbConnection>(sp => new NpgsqlConnection(builder.Configuration.GetConnectionString("Postgresql")));
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddScoped<IDbTransaction>(sp =>
{

    var connection = sp.GetRequiredService<IDbConnection>();
    connection.Open();
    return connection.BeginTransaction();


});



builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());






var app = builder.Build();



using (var scope = app.Services.CreateScope())
{
    var dbConnection = scope.ServiceProvider.GetRequiredService<IDbConnection>();

    dbConnection.Open();
    await Seed.Create(dbConnection);
}


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
