using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OnlineCourses.CodeFirst.Data;

//var host = Host.CreateDefaultBuilder(args)
//    .ConfigureServices((context, services) =>
//    {
//        var connectionString = context.Configuration.GetConnectionString("OnlineCoursesDb")
//                               ?? "Server=(localdb)\\mssqllocaldb;Database=OnlineCoursesDb;Trusted_Connection=True;";
//        services.AddDbContext<AppDbContext>(options =>
//            options.UseSqlServer(connectionString));
//    })
//    .Build();

//// Применение миграций при старте (опционально)
//using (var scope = host.Services.CreateScope())
//{
//    var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
//    db.Database.Migrate();
//}

//await host.RunAsync();