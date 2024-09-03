/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using BrainAColada.Interfaces.Factories;
using System.Numerics;

namespace BrainAColada.BuiltIn.Optimizers.Factory
{
    public class TrigonometricBoundedAdamOptimizerFactory<T> : IOptimizationAlgorithmFactory<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public IOptimizationAlgorithm<T> Create(IParams<T> optimizerParams)
        {
            return new TrigonometricBoundedAdamOptimizer<T>(optimizerParams);
        }

        public string GetName()
        {
            return "BoundedAdam_Trigonometric";
        }
    }
}
