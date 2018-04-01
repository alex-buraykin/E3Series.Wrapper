namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    public interface IE3Identificated
    {
        /// <summary>
        /// Get object identifier
        /// </summary>
        /// <returns>Object identifier</returns>
        int GetId();

        /// <summary>
        /// Set identifier to object
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Object identifier</returns>
        int SetId(int id);

        /// <summary>
        /// Object identifier
        /// </summary>
        int Id { get; set; }
    }
}