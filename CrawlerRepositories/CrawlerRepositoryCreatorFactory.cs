using System;
using CrawlerRepoInterfaces;
using Microsoft.Extensions.DependencyInjection;

namespace CrawlerRepositories;

public sealed class CrawlerRepositoryCreatorFactory(IServiceProvider services) : ICrawlerRepositoryCreatorFactory
{
    public ICrawlerRepository GetCrawlerRepository()
    {
        // ReSharper disable once using
        using IServiceScope scope = services.CreateScope();
        return scope.ServiceProvider.GetRequiredService<ICrawlerRepository>();
    }
}
