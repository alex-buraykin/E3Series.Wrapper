﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IDimension" />
    /// <summary>
    /// Implementation of IDimension interface
    /// </summary>
    public class E3Dimension : ComWrapperBase<E3DimensionProxy>, IDimension
    {
        public E3Dimension(E3Job job)
            : base(job, () => new E3DimensionProxy(job.ComObject.CreateDimensionObject()))
        {
        }
    }
}