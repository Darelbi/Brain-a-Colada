﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using BrainAColada.Interfaces.Factories;
using System.Numerics;

namespace BrainAColada.BuiltIn.LossFunction.Factory
{
    public class PseudoHuberLossFunctionFactory<T> : ILossFunctionFactory<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public ILossFunction<T> Create(IParams<T> huberParams)
        {
            return new PseudoHuberLossFunction<T>(huberParams);
        }

        public string GetName()
        {
            return "PseudoHuber";
        }
    }
}
