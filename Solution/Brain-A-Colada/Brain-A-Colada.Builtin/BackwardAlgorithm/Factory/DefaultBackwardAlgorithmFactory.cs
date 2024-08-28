/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/BrainAColada/ */
using BrainAColada.BuiltIn.BackwardAlgorithm;
using BrainAColada.Interfaces;
using BrainAColada.Interfaces.Factories;
using System.Numerics;

namespace BrainAColada.BuiltIn.ForwardAlgorithm.Factory
{
    public class DefaultBackwardAlgorithmFactory<T> : IBackwardAlgorithmFactory<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public IBackwardAlgorithm<T> Create(ILossFunction<T> lossFunction)
        {
            return new DefaultBackwardAlgorithm<T>(lossFunction);
        }

        public string GetName()
        {
            return "Default";
        }
    }
}
