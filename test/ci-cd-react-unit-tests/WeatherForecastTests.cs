using ci_cd_react;
using Shouldly;
using Xunit;

namespace ci_cd_react_unit_tests
{
    public class WeatherForecastTests
    {
        [Fact]
        public void WeatherForecast_Celsius100_ShouldBe_Fahrenheit211()
        {
            var sut = new WeatherForecast { TemperatureC = 100 };

            sut.TemperatureF.ShouldBe(211);
        }
    }
}