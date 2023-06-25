using Agrokultura.Controllers;
using Agrokultura.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Agrokultura.UnitTests
{
  
    public class CitiesControllerTests
    {
        [Fact]
        public async Task Index_ReturnsViewResultWithListOfCities()
        {
            // Arrange
            var mockOptions = new DbContextOptions<AgroContext>();
            var mockContext = new Mock<AgroContext>(mockOptions);
            var controller = new CitiesController(mockContext.Object);

            var mockCities = new List<City>
            {
                new City { Id = 1, Name = "City 1" },
                new City { Id = 2, Name = "City 2" },
                new City { Id = 3, Name = "City 3" }
            };

            var mockDbSet = new Mock<DbSet<City>>();
            mockDbSet.As<IQueryable<City>>().Setup(m => m.Provider).Returns(mockCities.AsQueryable().Provider);
            mockDbSet.As<IQueryable<City>>().Setup(m => m.Expression).Returns(mockCities.AsQueryable().Expression);
            mockDbSet.As<IQueryable<City>>().Setup(m => m.ElementType).Returns(mockCities.AsQueryable().ElementType);
            mockDbSet.As<IQueryable<City>>().Setup(m => m.GetEnumerator()).Returns(mockCities.AsQueryable().GetEnumerator());
            mockDbSet.As<IAsyncEnumerable<City>>().Setup(m => m.GetAsyncEnumerator(It.IsAny<CancellationToken>())).Returns(new TestAsyncEnumerator<City>(mockCities.GetEnumerator()));

            mockContext.Setup(c => c.Cities).Returns(mockDbSet.Object);

            // Act
            var result = await controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var model = Assert.IsAssignableFrom<List<City>>(viewResult.ViewData.Model);
            Assert.Equal(mockCities.Count, model.Count);
        }

     
    }


}

public class TestAsyncEnumerator<T> : IAsyncEnumerator<T>
{
    private readonly IEnumerator<T> enumerator;

    public TestAsyncEnumerator(IEnumerator<T> enumerator)
    {
        this.enumerator = enumerator;
    }

    public T Current => enumerator.Current;

    public ValueTask<bool> MoveNextAsync()
    {
        return new ValueTask<bool>(enumerator.MoveNext());
    }

    public ValueTask DisposeAsync()
    {
        enumerator.Dispose();
        return new ValueTask();
    }

}
