using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    public interface ITreeNode
    {
        void SetData(Object data);
        void SetParent(ITreeNode parent);
        Object GetData();
        ITreeNode GetParent();
        Object GetRoot();
        int GetChildCount();
        bool IsLeaf();
        void AddChild(ITreeNode child);
        bool RemoveChild(ITreeNode child);
    }
}

