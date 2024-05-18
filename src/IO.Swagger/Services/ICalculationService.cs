using IO.Swagger.Models;
using System.Threading.Tasks;

namespace IO.Swagger.Services
{
    /// <summary>
    /// Interface ICalculationService
    /// </summary>
    public interface ICalculationService
    {
        /// <summary>
        /// PerformCalculation method
        /// </summary>
        double PerformCalculation(OperationRequest model,string operation);
    }
}
