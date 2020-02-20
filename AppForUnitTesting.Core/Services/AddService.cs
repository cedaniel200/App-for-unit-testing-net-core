using AppForUnitTesting.Core.Dtos;
using AppForUnitTesting.Core.Enum;
using AppForUnitTesting.Core.IServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppForUnitTesting.Core.Services
{
    public class AddService : IOperator
    {
        public decimal calculate(Calculator calculator)
        {
            return calculator.OperatorOne + calculator.OPeratorTwo;
        }

        public OperationType OperationType()
        {
            return Enum.OperationType.Add;
        }
    }
}
