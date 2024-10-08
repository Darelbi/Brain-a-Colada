﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces.Layers;
using System.Numerics;

namespace BrainAColada.Interfaces
{
    public interface IOptimizationAlgorithm<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public void Initialize(IGradientsLayer<T> layer, ILayerAllocatedVariables<T> variables, IRunningMetadata<T> runningMetadata);

        public void Optimize(IGradientsLayer<T> layer, ILayerAllocatedVariables<T> variables, IRunningMetadata<T> runningMetadata);

        public T GetUpdatedLearningRate(T learningRate);
    }
}
