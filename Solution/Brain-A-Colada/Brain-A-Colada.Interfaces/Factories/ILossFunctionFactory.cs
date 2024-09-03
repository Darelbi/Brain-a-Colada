﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using System.Numerics;

namespace BrainAColada.Interfaces.Factories
{
    public interface ILossFunctionFactory<T> : IFactory where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public ILossFunction<T> Create(IParams<T> lossParams);
    }
}
