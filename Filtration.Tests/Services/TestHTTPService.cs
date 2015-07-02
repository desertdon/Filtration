﻿using Filtration.Services;
using NUnit.Framework;

namespace Filtration.Tests.Services
{
    [Ignore("Integration Test - Makes real HTTP call")]
    [TestFixture]
    public class TestHTTPService
    {
        [Test]
        public async void GetContent_FetchesDataFromUrl()
        {
            // Arrange
            var service = new HTTPService();

            // Act
            var result = await service.GetContentAsync("http://ben-wallis.github.io/Filtration/filtration_version.xml");

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
