﻿/*
    Author: Dario Oliveri ( https://github.com/Darelbi )
    Copyright (c) 2024 Dario Oliveri
    License: MIT (see LICENSE file in repository root for more detail)
    Original Project: https://github.com/Darelbi/BrainAColada/ */
using System.Numerics;

namespace BrainAColada.Interfaces
{
    public interface IRunningMetadata<T>: IStepSource, IEpochSource,
            ILearningSource<T> where T : INumber<T>, IFloatingPointIeee754<T>
    {
    }
}
