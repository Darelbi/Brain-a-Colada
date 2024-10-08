﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using System.Numerics;

namespace BrainAColada
{
    public class NeuraBuilder<T> : INeuraBuilder<T> where T:INumber<T>, IFloatingPointIeee754<T>
    {
        private List<INeuralLayer<T>> layers = [];
        private IForwardAlgorithm<T> algorithm = null!;

        public INeuraNetwork<T> Compile()
        {
            if (algorithm == null)
                throw new ArgumentNullException("No optimization algorithm selected");

            if (layers.Count < 2)
                throw new ArgumentException("At least two layers (input,output) required");

            if (layers.Any(x => x == null))
                throw new ArgumentException("Some layers were null");

            //return new NeuraNetwork<T>([.. layers], algorithm);
            return null!;
        }
    }
}
