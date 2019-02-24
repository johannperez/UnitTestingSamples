using Moq;
using SampleLibrary;
using Xunit;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void CorrectTest()
        {
            var mockNavigationService = new Mock<INavigationService>();

            var sampleClassInstance = new SamlpeClass(mockNavigationService.Object);

            sampleClassInstance.SampleCommand.Execute(null);

            mockNavigationService.Verify(s => s.Navigate(It.Is<NavigationParameter>(p => p.Prop2 == "value2" && p.Prop1 == "value1")));
        }

        [Fact]
        public void WrongTest()
        {
            var mockNavigationService = new Mock<INavigationService>();

            var sampleClassInstance = new SamlpeClass(mockNavigationService.Object);

            sampleClassInstance.SampleCommand.Execute(null);

            var parameter = new NavigationParameter
            {
                Prop1="value1",
                Prop2="value2"
            };

            mockNavigationService.Verify(s => s.Navigate(parameter));
        }

    }
}
