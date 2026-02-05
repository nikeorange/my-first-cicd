using Xunit;
using Microsoft.AspNetCore.Mvc;
using MyWebApi.Controllers;

namespace MyWebApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test_Controller_Returns_Hello()
    {
        // Arrange
        var controller = new WeatherForecastController();
        
        // Act
        var result = controller.Get();
        
        // Assert
        Assert.Equal("Hello CI/CD!", result);
    }
    
    [Fact]
    public void Test_Add_Method_Works()
    {
        // Arrange
        var controller = new WeatherForecastController();
        
        // Act
        var result = controller.Add(2, 3);
        
        // Assert
        Assert.Equal(5, result);
    }
    
    [Fact]
    public void Test_Add_With_Negative_Numbers()
    {
        // Arrange
        var controller = new WeatherForecastController();
        
        // Act
        var result = controller.Add(-5, 10);
        
        // Assert
        Assert.Equal(5, result);
    }
}