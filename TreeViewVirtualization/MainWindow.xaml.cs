using System.Windows;
using System.Windows.Controls;

namespace TreeViewVirtualization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static MainWindow()
        {
            VirtualizingPanel.VirtualizationModeProperty.OverrideMetadata(
                typeof(VirtualizingPanel), new FrameworkPropertyMetadata(VirtualizationMode.Recycling));
            VirtualizingPanel.VirtualizationModeProperty.OverrideMetadata(
                typeof(MainWindow), new FrameworkPropertyMetadata(VirtualizationMode.Recycling));
            VirtualizingPanel.VirtualizationModeProperty.OverrideMetadata(
                typeof(TreeViewItem), new FrameworkPropertyMetadata(VirtualizationMode.Recycling));
            VirtualizingPanel.VirtualizationModeProperty.OverrideMetadata(
                typeof(VirtualizingStackPanel), new FrameworkPropertyMetadata(VirtualizationMode.Recycling));
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
