﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using BrainAColada.Interfaces.Layers;
using System.Numerics;

namespace BrainAColada.BuiltIn.BiasInitialization
{
    public class ZeroBiasInitializer<T> : IBiasInitialization<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public ZeroBiasInitializer()
        {
        }
        public void Initialize(IBiasLayer<T> weights)
        {
            // do nothing. C# already initialize arrays to 0.
        }
    }
}
