﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Dimension COM object
    /// </summary>
    public interface IDimension : IProxyProvider<E3DimensionProxy>,
        IE3Identificated, IE3IdentificatedGlobal, IE3Attributed
    {
    }
}