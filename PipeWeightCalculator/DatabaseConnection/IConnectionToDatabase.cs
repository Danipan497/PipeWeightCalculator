using PipeWeightCalculator.Dtos;

namespace PipeWeightCalculator.DatabaseConnection
{
    public interface IConnectionToDatabase
    {
        PipesPropertiesDto PopulateDatabase();
    }
}