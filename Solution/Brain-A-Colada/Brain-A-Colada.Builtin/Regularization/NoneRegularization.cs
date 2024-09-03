/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using System.Numerics;

namespace BrainAColada.BuiltIn.Regularization
{
    /// <summary>
    /// Realdrop out, for networks of 30+ neurons it should not matter even if 1 time we get a dead layer
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class NoneRegularization<T>() : IRegularizationAlgorithm<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public void FinalNormalizationStep(INeuralLayer<T> layer)
        {
            
        }

        public void Regularize(INeuralLayer<T> layer)
        {
            
        }
    }
}
