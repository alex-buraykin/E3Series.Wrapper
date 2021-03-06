﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base.Interfaces;

namespace E3Series.Wrapper.Entities.Interfaces
{
    /// <inheritdoc />
    /// <summary>
    /// Interface for class-wrapper of e3Board COM object
    /// </summary>
    public interface IBoard : IProxyProvider<E3BoardProxy>,
        IE3Identificated, IE3NamedReadonly, IE3IdentificatedGlobal
    {
    }
}