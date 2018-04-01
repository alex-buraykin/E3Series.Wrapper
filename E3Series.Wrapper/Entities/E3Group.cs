using System;
using System.Collections.Generic;
using System.Linq;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Extensions;
using E3Series.Wrapper.Entities.Interfaces;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IGroup" />
    /// <summary>
    /// Implementation of IGroup interface
    /// </summary>
    public class E3Group : ProxyWrapperBase<E3GroupProxy>, IGroup
    {
        public E3Group(E3Job job)
            : base(job, () => new E3GroupProxy(job.Proxy.CreateGroupObject()))
        {
        }

        #region Implementation of IE3Identificated

        /// <inheritdoc />
        public int GetId() => Proxy.GetId();

        /// <inheritdoc />
        public int SetId(int id) => Proxy.SetId(id);

        /// <inheritdoc />
        public int Id
        {
            get => GetId();
            set => SetId(value);
        }

        #endregion

        #region Implementation of IE3NamedReadonly

        /// <inheritdoc />
        public string GetName() => Proxy.GetName();

        #endregion

        #region Implementation of IE3Named

        /// <inheritdoc />
        public bool SetName(string name) => Proxy.SetName(name).CastToBool();

        /// <inheritdoc />
        public string Name
        {
            get => GetName();
            set => Proxy.SetName(value);
        }

        #endregion

        #region Implementation of IE3IdentificatedGlobal

        /// <inheritdoc />
        public string GlobalId => GetGlobalId();

        /// <inheritdoc />
        public string GetGlobalId() => ((IJob)Parent).GetGidOfId(Id);

        /// <inheritdoc />
        public int SetId(string globalId) => Proxy.SetId(((IJob)Parent).GetIdOfGid(globalId));

        #endregion

        #region Implementation of IE3Attributed

        /// <inheritdoc />
        [Obsolete("Method is not supported", true)]
        public bool HasAttribute(string attributeName) => throw new NotSupportedException("Method is not supported");

        /// <inheritdoc />
        public string GetAttributeValue(string attributeName) => Proxy.GetAttributeValue(attributeName);

        /// <inheritdoc />
        public int SetAttributeValue(string attributeName, string attributeValue) => Proxy.SetAttributeValue(attributeName, attributeValue);

        /// <inheritdoc />
        public IEnumerable<int> GetAttributeIds() => Proxy.GetAttributeIdsList();

        /// <inheritdoc />
        public IEnumerable<IAttribute> GetAttributes(IAttribute iterator) => iterator.GetEnumerable(GetAttributeIds);

        /// <inheritdoc />
        public IEnumerable<IAttribute> GetAttributes(IAttribute iterator, string attributeName) =>
            GetAttributes(iterator)
                .Where(a => a.CheckName(attributeName));

        /// <inheritdoc />
        public int DeleteAttribute(string attributeName) => Proxy.DeleteAttribute(attributeName);

        #endregion
    }
}