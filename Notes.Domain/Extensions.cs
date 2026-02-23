using Microsoft.Extensions.DependencyInjection;

namespace Notes.Domain;

public static class Extensions
{
    public static IServiceCollection AddDomain(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<INoteService, NoteService>();
        return serviceCollection;
    }
}