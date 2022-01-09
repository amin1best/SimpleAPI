using Xunit;
using System;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging.Abstractions;

namespace SimpleAPI.Test;

public class UnitTest1
{
    WeatherForecastController controller = new WeatherForecastController(new NullLogger<WeatherForecastController>());

    [Fact]
    public void GetReturn()
    {
        var returnValue = controller.Get(1);
        Assert.Equal("Hello Amin", returnValue.Value);
    }
}