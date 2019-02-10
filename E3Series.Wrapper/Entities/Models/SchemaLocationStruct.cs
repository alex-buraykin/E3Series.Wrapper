namespace E3Series.Wrapper.Entities.Models
{
    public struct SchemaLocationStruct
    {
        /// <summary>
        /// X-coordinate
        /// </summary>
        public double X;

        /// <summary>
        /// Y-coordinate
        /// </summary>
        public double Y;

        /// <summary>
        /// Grid
        /// </summary>
        public string Grid;

        /// <summary>
        /// Id of sheet
        /// </summary>
        public int SheetId;

        public SchemaLocationStruct(double x, double y, string grid, int sheetId)
        {
            X = x;
            Y = y;
            Grid = grid;
            SheetId = sheetId;
        }
    }
}