using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TreeViewVirtualization
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel()
        {
            var treeItems = new TreeItem[1];
            for (int i = 0; i < 1; i++)
            {
                var children = new List<TreeItem>();
                for (int j = 0; j < 100000; j++)
                {
                    children.Add(new TreeItem($"Child {j + 1}", null));
                }
                treeItems[i] = new TreeItem($"Ti {i + 1}", children);
                treeItems[i].IsExpanded = true;
            }
            TreeItems = treeItems;
        }

        public TreeItem[] TreeItems { get; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void onPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
