using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Data;

namespace TreeViewVirtualization
{
    public class TreeItem : INotifyPropertyChanged
    {
        private bool isExpanded;

        public TreeItem(object item, List<TreeItem> children)
        {
            Item = item;
            Children = children;
        }

        public object Item { get; }
        public List<TreeItem> Children { get; }
        public bool IsExpanded
        {
            get => isExpanded;
            set
            {
                isExpanded = value;
                onPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
