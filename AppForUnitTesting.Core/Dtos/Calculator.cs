using AppForUnitTesting.Core.Enum;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace AppForUnitTesting.Core.Dtos
{
    [DataContract]
    public class Calculator
    {
        [DataMember]
        public decimal OperatorOne { get; set; }

        [DataMember]
        public decimal OPeratorTwo { get; set; }

        [DataMember]
        public OperationType Operation { get; set; }

    }
}
