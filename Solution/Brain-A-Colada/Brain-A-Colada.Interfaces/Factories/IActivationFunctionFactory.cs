﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/BrainAColada/ */
using System.Numerics;

namespace BrainAColada.Interfaces.Factories
{
    public interface IActivationFunctionFactory<T> : IFactory where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public IActivationFunction<T> Create(IParams<T> activationParams);
    }
}
