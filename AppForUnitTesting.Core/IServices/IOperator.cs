using AppForUnitTesting.Core.Dtos;
using AppForUnitTesting.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppForUnitTesting.Core.IServices
{
    public interface IOperator
    {
        OperationType OperationType();
        decimal calculate(Calculator calculator);
    }
}
