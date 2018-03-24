using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.SelectionDialog.WPF.ViewModels;

namespace E3Series.Wrapper.SelectionDialog.WPF
{
    /// <inheritdoc />
    /// <summary>
    /// Connector use WPF SelectionDialog by default
    /// </summary>
    public class WpfConnector : ConnectorBase
    {
        public override IApplication Connect()
        {
            return Connect(new SelectionViewModel());
        }
    }
}
