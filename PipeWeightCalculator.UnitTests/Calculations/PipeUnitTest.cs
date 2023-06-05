using FluentAssertions;
using NUnit.Framework;
using PipeWeightCalculator.Calculations;

namespace PipeWeightCalculator.UnitTests.Calculations
{
    public class PipeUnitTest
    {
        [Test]
        public void CalculatePipeWeight_ShouldReturnEmptyString_ThicknessIsLowerThanDiameter()
        {
            //arrange
            string expectedResult = "";
            double wallThickness = 120;
            double pipeNominalDiameter = 60.3;
            double pipeLength = 1;
            int material = 7840;

            //act
            var pipeResult = new Pipe();
            string result = pipeResult.CalculatePipeWeight(pipeNominalDiameter, wallThickness, pipeLength, material);

            //assert
            result.Should().NotBeNull();
            result.Should().Be(expectedResult);
        }

        [Test]
        public void CalculatePipeWeight_ShouldRetunCorrectValue()
        {
            string expectedResult = "4,100";
            double wallThickness = 2.9;
            double pipeNominalDiameter = 60.3;
            double pipeLength = 1;
            int material = 7840;

            string result = new Pipe().CalculatePipeWeight(pipeNominalDiameter, wallThickness, pipeLength, material);

            result.Should().NotBeNull();
            result.Should().Be(expectedResult);
        }
    }
}
