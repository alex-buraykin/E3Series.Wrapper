namespace E3Series.Wrapper.Entities.Base.Interfaces
{
    public interface IE3Named : IE3NamedReadonly
    {
        /// <summary>
        /// Set name for object
        /// </summary>
        /// <param name="name">New name</param>
        /// <returns></returns>
        bool SetName(string name);

        /// <summary>
        /// Name of object
        /// </summary>
        string Name { get; set; }
    }
}