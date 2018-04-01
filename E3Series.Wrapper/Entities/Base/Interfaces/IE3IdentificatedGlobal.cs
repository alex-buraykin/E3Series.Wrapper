namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    public interface IE3IdentificatedGlobal
    {
        /// <summary>
        /// Global identifier
        /// </summary>
        string GlobalId { get; }

        /// <summary>
        /// Get global identifier
        /// </summary>
        /// <returns></returns>
        string GetGlobalId();

        /// <summary>
        /// Set object identifier by global identifier
        /// </summary>
        /// <param name="globalId">Global identifier</param>
        /// <returns>Object identifier</returns>
        int SetId(string globalId);
    }
}