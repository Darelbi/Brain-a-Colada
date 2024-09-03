/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using System.Numerics;

namespace BrainAColada.Interfaces.Layers
{
    public interface ITotalGradientsLayer<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public T[] TotalGradients { get; set; }
    }
}
