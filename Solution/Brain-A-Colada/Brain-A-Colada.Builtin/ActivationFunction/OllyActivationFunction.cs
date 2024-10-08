﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/Brain-a-Colada */
using BrainAColada.Interfaces;
using System.Numerics;

namespace BrainAColada.BuiltIn.ActivationFunction
{
    /// <summary>
    /// Do not use this, I created it and I'm playing with it but beware there is no research going on with
    /// this function. I think it should avoid some problems providing some of the advantages of other
    /// functions. And it work well in SMALL tests, but no big test done so far!
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class OllyActivationFunction<T> : IActivationFunction<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
        public T Compute(T weightedSum)
        {
            if (weightedSum < T.Zero)
                return (T.Exp(weightedSum) - T.One);

            return T.Log(weightedSum + T.One);
        }

        public T Derivate(T weightedSum)
        {
            if (weightedSum < T.Zero)
                return T.Exp(weightedSum);

            return T.One / (weightedSum + T.One);
        }
    }
}
