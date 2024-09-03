/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using BrainAColada.Interfaces.Factories;
using System.Numerics;

namespace BrainAColada.BuiltIn.Regularization.Factory
{
    public class NoneRegularizationFactory<T> : IRegularizationAglorithmFactory<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public IRegularizationAlgorithm<T> Create(IParams<T> regulParams)
        {
            return new NoneRegularization<T>();
        }

        public string GetName()
        {
            return "None";
        }
    }
}
