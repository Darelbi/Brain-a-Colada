﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using System.Numerics;

namespace BrainAColada.BuiltIn.ActivationFunction
{
    public class LeakyReLUActivationFunction<T> : IActivationFunction<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public T Compute(T weightedSum)
        {
            if (weightedSum < T.Zero)
                return weightedSum * T.CreateChecked(0.01);

            return weightedSum;
        }

        public T Derivate(T weightedSum)
        {
            if (weightedSum < T.Zero)
                return T.CreateChecked(0.01);

            return T.One;
        }
    }
}
