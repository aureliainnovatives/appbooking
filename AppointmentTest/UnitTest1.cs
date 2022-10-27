using AppointmentBooking.Controllers;

namespace AppointmentTest
{
    public class UnitTest1
    {
        [Fact]
        public void CheckIfItReturnsCorrectName()
        {
            var controller = new WeatherForecastController();

            string fullname = controller.getName();


            Assert.Equal("John Snow", fullname);
        }
    }
}