namespace PipeWeightCalculator.Calculations
{
    public interface IPipe
    {
        string CalculatePipeWeight(double pipeNominalDiameterComboBoxValue, double wallThicknessComboBoxValue, double pipeLength, int materialComboBoxValue);
    }
}