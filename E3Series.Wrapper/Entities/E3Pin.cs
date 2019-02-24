using System.Collections.Generic;
using System.Linq;
using E3Series.Proxy;
using E3Series.Wrapper.Entities.Base;
using E3Series.Wrapper.Entities.Extensions;
using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.Entities.Models;

namespace E3Series.Wrapper.Entities
{
    /// <inheritdoc cref="IPin" />
    /// <summary>
    /// Implementation of IPin interface
    /// </summary>
    public class E3Pin : ProxyWrapperBase<E3PinProxy>, IPin
    {
        public E3Pin(E3Job job)
            : base(job, () => new E3PinProxy(job.Proxy.CreatePinObject()))
        {
        }

        /// <inheritdoc />
        public string SignalName
        {
            get => Proxy.GetSignalName();
            set => Proxy.SetSignalName(value);
        }

        /// <inheritdoc />
        public SignalNameType GetSignalNameType()
        {
            var signalName = SignalName;
            return string.IsNullOrWhiteSpace(signalName) 
                       ? SignalNameType.NotSet 
                       : signalName.StartsWith("#") 
                           ? SignalNameType.System 
                           : SignalNameType.User;
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
        public bool HasAttribute(string attributeName) => Proxy.HasAttribute(attributeName).CastToBool();

        /// <inheritdoc />
        public string GetAttributeValue(string attributeName) => Proxy.GetAttributeValue(attributeName);

        /// <inheritdoc />
        public int SetAttributeValue(string attributeName, string attributeValue) => Proxy.SetAttributeValue(attributeName, attributeValue);

        /// <inheritdoc />
        public IEnumerable<int> GetAttributeIds() => Proxy.GetAttributeIdsEnumerable();

        /// <inheritdoc />
        public IEnumerable<IAttribute> GetAttributes(IAttribute iterator) => iterator.GetEnumerable(GetAttributeIds);

        /// <inheritdoc />
        public IEnumerable<IAttribute> GetAttributes(IAttribute iterator, string attributeName) =>
            GetAttributes(iterator)
                .Where(a => a.CheckName(attributeName));

        /// <inheritdoc />
        public int DeleteAttribute(string attributeName)
            => Proxy.DeleteAttribute(attributeName);

        /// <inheritdoc />
        public ISheet GetSheet(ISheet iterator) 
            => iterator.SetId(Proxy.GetSchemaLocationStruct()?.SheetId ?? 0) == 0 ? null : iterator;

        #endregion

        #region Implementation of IE3SchemaLocation

        /// <inheritdoc />
        public bool IsPlaced() => Proxy.IsPlaced();

        /// <inheritdoc />
        public SchemaLocationStruct? GetSchemaLocationStruct() => Proxy.GetSchemaLocationStruct();

        #endregion
    }
}