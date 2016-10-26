using System;
using E3Series.Wrapper.Entities.Interfaces;
using E3Series.Wrapper.Interfaces;
using E3Series.Wrapper.SelectionDialog.WPF.ViewModels;

namespace E3Series.Wrapper.SelectionDialog.WPF
{
    /// <summary>
    /// Connector use WPF SelectionDialog by default
    /// </summary>
    public class WpfConnector : BaseConnector
    {
        #region IConnector Members

        public override IApplication Connect()
        {
            return base.Connect(new SelectionViewModel());
        }

        [Obsolete("Use Connect() method instead", false)]
        public override IApplication Connect(IConnectorSelectionDialog connectorSelectionDialog)
        {
            return base.Connect(connectorSelectionDialog);
        }

        #endregion
    }
}
