using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    internal interface ICalculator
    {
        //Interfaces
        // An Interface is defined as a syntactical contract that all classes inheriting the interface should follow.
        // The inheritance defines the "what" part of the syntactical contract and the deriving classes define  the "how" part of the syntactical contract.

        void Compute(double numA, double numB, String operation);

        void TurnOff();

    }
}
