using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionTutorial;

public class FuelOverflowException : Exception
{
    public double AmountAdded { get; }
    public double CurrentFuelLevel { get; }
    public double ExcessAmount { get; }

    public FuelOverflowException(double amountAdded, double currentFuelLevel, double tankCapacity)
        : base($"Cannot add {amountAdded} l of fuel to a tank that already contains {currentFuelLevel} l."+
            $"This would exceed the capacity of {tankCapacity}l by  {amountAdded + currentFuelLevel - tankCapacity}l")
    {
        AmountAdded = amountAdded;
        CurrentFuelLevel = currentFuelLevel;
        ExcessAmount = amountAdded + currentFuelLevel - tankCapacity;
    }
}