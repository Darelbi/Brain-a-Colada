﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/BrainAColada/ */
using System.Numerics;

namespace BrainAColada.Interfaces.Layers
{
    public interface IDerivateLayer<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public T[] Derivates { get; set; }
    }
}
