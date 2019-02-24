namespace E3Series.Wrapper.Entities.Models
{
    public enum SymbolModeEnum
    {
        /// <summary>
        /// All symbols
        /// </summary>
        AllSymbols = 0,

        /// <summary>
        /// Only placed symbols
        /// </summary>
        OnlyPlacedSymbols = 1,

        /// <summary>
        /// Only unplaced symbols
        /// </summary>
        OnlyUnplacedSymbols = 2,

        /// <summary>
        /// All symbols, including assigned attribute template symbols
        /// </summary>
        AllSymbolsIncludingAssignedAttributeTemplateSymbols = 3,

        /// <summary>
        /// Only assigned attribute template symbols
        /// </summary>
        OnlyAssignedAttributeTemplateSymbols = 4,

        /// <summary>
        /// Only twisted pair ans shield symbols (for cables)
        /// </summary>
        OnlyCableProtectionSymbols = 5
    }
}