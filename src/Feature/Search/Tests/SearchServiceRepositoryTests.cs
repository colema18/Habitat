﻿namespace Sitecore.Feature.Search.Tests
{
  using FluentAssertions;
  using Sitecore.Feature.Search.Repositories;
  using Sitecore.Feature.Search.Tests.Extensions;
  using Sitecore.Foundation.Indexing;
  using Sitecore.Foundation.Testing.Attributes;
  using Xunit;

  public class SearchServiceRepositoryTests
  {
    [Theory]
    [AutoDbData]
    public void ShouldReturnSearchService(ISearchSettingsRepository settingsRepository)
    {
      var repository = new SearchServiceRepository(settingsRepository);
      var service = repository.Get();
      service.Should().BeOfType<SearchService>();
    }
  }
}
