using PipeWeightCalculator.WeightDataSetTableAdapters;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;

namespace PipeWeightCalculator.DatabaseConnection
{
    public interface IConnectionToDatabase
    {
        void PDatabase();
    }
}
