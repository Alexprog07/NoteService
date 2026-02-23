using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Notes.DataBases;

public static class Extensions
{
    public static IServiceCollection AddDataBases(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<INoteRepository, NoteRepository>();
        serviceCollection.AddDbContext<Context>(x =>
        {
            x.UseNpgsql("Host=localhost;Database=NoteDb;Username=postgres;Password=1234");

        });
        return serviceCollection;
    }
}