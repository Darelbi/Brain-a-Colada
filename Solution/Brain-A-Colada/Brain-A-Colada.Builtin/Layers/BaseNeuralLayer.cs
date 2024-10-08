﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using System.Numerics;

namespace BrainAColada.BuiltIn.Layers
{
    public class BaseNeuralLayer<T> : INeuralLayer<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        private readonly IActivationFunction<T> activation;
        private readonly IRegularizationAlgorithm<T>[] regularizers;

        public T[] Outputs { get; set; }
        public T[] Derivates { get; set; }
        public T[][] Weights { get; set; }
        public T[] Biases { get; set; }
        public T[] Gradients { get; set; }
        public T[] TotalGradients { get; set; }

        public int Index { get; set; }

        public BaseNeuralLayer(int index, int inputs, int outputs, 
            IWeightInitialization<T> winit, 
            IBiasInitialization<T> biasesInit,
            IActivationFunction<T> activation, 
            params IRegularizationAlgorithm<T>[] regularizers)
        {
            this.activation = activation;
            this.regularizers = regularizers;
            
            // this is the most stupidest warning of c#
            Index = index;
            Outputs = new T[outputs];
            Derivates = new T[outputs];
            Gradients = new T[outputs];
            TotalGradients = new T[outputs];
            Biases = new T[outputs];

            Weights = new T[outputs][];

            for (int i = 0; i < outputs; i++)
            {
                Weights[i] = new T[inputs];
            }

            winit.Initialize(this);
            biasesInit.Initialize(this);
        }

        public IActivationFunction<T> GetActivationFunction()
        {
            // the function is layer specific that's why we need it there
            return activation;
        }

        public IRegularizationAlgorithm<T>[] GetRegularizers()
        {
            return regularizers;
        }
    }
}
