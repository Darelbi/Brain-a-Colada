﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using BrainAColada.Interfaces.Enums;
using BrainAColada.Interfaces.Layers;
using System.Numerics;

namespace BrainAColada.BuiltIn.WeightInitialization
{
    /// <summary>
    /// This initialization works best for sigmoid or tanh functions
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class UniformInitialization<T>(IParams<T> uniformParams) : IWeightInitialization<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        private readonly T min = uniformParams.GetParameter(Params.Min);
        private readonly T max = uniformParams.GetParameter(Params.Max);

        public void Initialize(IWeightsLayer<T> weights)
        {
            for(int l = 0; weights.Weights.Length > l; l++)
            {
                for(int j=0; weights.Weights[l].Length > j; j++)
                {
                    T rnd = T.CreateChecked(Random.Shared.NextDouble());
                    weights.Weights[l][j] = min + rnd * (max - min);
                }
            }
        }
    }
}
