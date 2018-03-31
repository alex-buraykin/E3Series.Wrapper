namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    public interface IE3Identificated
    {
        /// <summary>
        /// Get object Id
        /// </summary>
        /// <returns>Object Id</returns>
        int GetId();

        /// <summary>
        /// Set Id to object
        /// </summary>
        /// <param name="id">Id</param>
        /// <returns>Object Id</returns>
        int SetId(int id);

        /// <summary>
        /// Object Id
        /// </summary>
        int Id { get; set; }
    }
}