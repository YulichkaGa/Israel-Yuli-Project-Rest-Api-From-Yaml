
using System;
using IO.Swagger.Models;

namespace IO.Swagger.Services
{
    /// <summary>
    ///CalculationService
    /// </summary>
    public class CalculationService : ICalculationService
    {

        /// <summary>
        ///PerformCalculation method
        /// </summary>
        public double PerformCalculation(OperationRequest model, string operation)
        {
            //check if model is NULL
            if (model == null)
            {
                throw new ArgumentNullException(nameof(model), "Calculation model must not be null.");
            }
            //check if number1 and number2 contains value
            if (!model.Number1.HasValue || !model.Number2.HasValue)
            {
                throw new ArgumentException("Both numbers must be provided.");
            }
            //check if operation==NULL OR Empty
            if (string.IsNullOrWhiteSpace(operation))
            {
                throw new ArgumentException("Operation must be specified.");
            }

            double number1 = model.Number1.Value;
            double number2 = model.Number2.Value;

            switch (operation.ToLower())
            {
                case "add":
                    return number1 + number2;
                case "subtract":
                    return number1 - number2;
                case "multiply":
                    return number1 * number2;
                case "divide":
                    if (number2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    return number1 / number2;
                default:
                    throw new ArgumentException("Invalid operation specified.");
            }
        }
    }
}