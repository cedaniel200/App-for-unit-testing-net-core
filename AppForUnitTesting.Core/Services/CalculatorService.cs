using AppForUnitTesting.Core.Dtos;
using AppForUnitTesting.Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppForUnitTesting.Core.Services
{
    public class CalculatorService : ICalculatorService
    {
        private readonly IList<IOperator> operators;

        public CalculatorService(IList<IOperator> operatorParam)
        {
            operators = operatorParam;
        }

        public decimal Calculate(Calculator calculator)
        {
            IOperator selectedOperator = operators.FirstOrDefault(op => op.OperationType().Equals(calculator.Operation));
            return selectedOperator.calculate(calculator);
        }
    }
}
