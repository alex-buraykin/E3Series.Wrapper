﻿using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="ILayer" />
    /// <summary>
    /// Implementation of ILayer interface
    /// </summary>
    public class E3Layer : ComWrapperBase<E3LayerProxy>, ILayer
    {
        public E3Layer(E3Job job)
            : base(job, () => new E3LayerProxy(job.ComObject.CreateLayerObject()))
        {
        }

        #region Implementation of IE3Identificated

        /// <inheritdoc />
        public int GetId() => ComObject.GetId();

        /// <inheritdoc />
        public int SetId(int id) => ComObject.SetId(id);

        /// <inheritdoc />
        public int Id
        {
            get => GetId();
            set => SetId(value);
        }

        #endregion

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => ComObject.GetName();

        #endregion

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        /// <inheritdoc />
        public string GetGlobalId() => ((IJob)Parent).GetGidOfId(Id);

        /// <inheritdoc />
        public int SetId(string globalId) => ComObject.SetId(((IJob)Parent).GetIdOfGid(globalId));

        #endregion
    }
}