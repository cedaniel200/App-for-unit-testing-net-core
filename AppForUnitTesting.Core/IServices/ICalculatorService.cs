using AppForUnitTesting.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppForUnitTesting.Core.IServices
{
    public interface ICalculatorService
    {
        decimal Calculate(Calculator calculator);
    }
}
