using IO.Swagger;
using IO.Swagger.Controllers;
using IO.Swagger.Models;
using IO.Swagger.Services;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace UnitTests
{

    public class ArithmeticServiceTests
    {
        private readonly CalculationService _arithmeticService = new CalculationService();

        [Theory]
        [InlineData(5, 2, "add", 7)]
        [InlineData(5, 3, "subtract", 2)]
        [InlineData(4, 2, "multiply", 8)]
        [InlineData(10, 2, "divide", 5)]
        public void Calculate_ValidOperations_ReturnsExpectedResult(double value1, double value2, string operation, double expected)
        {
            var request = new OperationRequest {Number1 = value1,Number2 = value2};
            string _operation = operation;
            var result = _arithmeticService.PerformCalculation(request,_operation);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Calculate_DivideByZero_ThrowsArgumentException()
        {
            var request = new OperationRequest {Number1 = 10,Number2 = 0};
            string operation = "divide";
            Assert.Throws<ArgumentException>(() => _arithmeticService.PerformCalculation(request, operation));
        }

        [Theory]
        [InlineData(10, 5, "modulus")]
        public void Calculate_InvalidOperation_ThrowsArgumentException(double value1, double value2, string operation)
        {
            var request = new OperationRequest {Number1 = value1,Number2 = value2};
            string _opearion = operation;
            Assert.Throws<ArgumentException>(() => _arithmeticService.PerformCalculation(request,_opearion));
        }
    }
}