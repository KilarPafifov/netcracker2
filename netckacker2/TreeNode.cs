using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class TreeNode : ITreeNode
    {
        private int data;
        private ITreeNode parent;
        private HashSet<ITreeNode> childset;
        public ITreeNode GetParent()
        {
            return parent;
        }

        public ITreeNode GetRoot()
        {
            if (this.parent == null)
            {
                return null;
            }
            return null; //доделать самому
        }

        public void SetParent(ITreeNode parent)
        {
            this.parent = parent;
        }

        public bool IsLeaf()
        {
            if (childset.Count == 0)
            {
                return true;
            }
            return false;
        }
        public int GetChildCount()
        {
            return childset.Count;
        }

        public void AddChild(ITreeNode child)
        {
            childset.Add(child);
            child.SetParent(this);
        }

        public bool RemoveChild(ITreeNode child)
        {
            return true;
        }
    }
}
