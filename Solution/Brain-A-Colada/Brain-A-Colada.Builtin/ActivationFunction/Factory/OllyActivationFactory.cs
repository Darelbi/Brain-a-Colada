﻿using BrainAColada.Interfaces.Factories;
using BrainAColada.Interfaces;
using System.Numerics;

namespace BrainAColada.BuiltIn.ActivationFunction.Factory
{
    public class OllyActivationFactory<T> : IActivationFunctionFactory<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public IActivationFunction<T> Create(IParams<T> activationParams)
        {
            return new OllyActivationFunction<T>();
        }

        public string GetName()
        {
            return "Olly";
        }
    }
}
