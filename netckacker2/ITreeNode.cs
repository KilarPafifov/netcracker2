using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    public interface ITreeNode
    {
        ITreeNode GetParent();
        void SetParent(ITreeNode parent);
        ITreeNode GetRoot();
        bool IsLeaf();
        int GetChildCount();
        void AddChild(ITreeNode child);
        bool RemoveChild(ITreeNode child);
    }
}

