namespace E3Series.Wrapper.SelectionDialog.WPF.Views.Interfaces
{
    /// <summary>
    /// Selection Dialog must implement this interface
    /// </summary>
    internal interface IDialogView
    {
        /// <summary>
        /// DataContext of View (etc. concrete ViewModel)
        /// </summary>
        object DataContext { get; set; }

        /// <summary>
        /// Close Dialog
        /// </summary>
        void Close();

        /// <summary>
        /// Show dialog
        /// </summary>
        /// <returns></returns>
        bool? ShowDialog();

        /// <summary>
        /// Dialog result
        /// </summary>
        bool? DialogResult { get; set; }
    }
}