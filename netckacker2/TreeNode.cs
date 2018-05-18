using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netckacker2
{
    class TreeNode : ITreeNode
    {
        private Object data;
        private ITreeNode parent;
        private HashSet<ITreeNode> childset = new HashSet<ITreeNode>();
        public void SetParent(ITreeNode parent)
        {
            this.parent = parent;
        }
        public void SetData(Object data)
        {
            this.data = data;
        }
        public ITreeNode GetParent()
        {
            return this.parent;
        }
        public Object GetData()
        {
            return data;
        }
        public Object GetRoot()
        {
            
            if (this.parent == null)
            {
                return null;
            }

            if (this.GetParent().GetParent() == null)
            {
                return this.parent;
            }
            while (this.GetParent().GetParent() != null)
            {
                this.parent = this.GetParent().GetParent();
            }
            
            return this.parent;
        }
        public int GetChildCount()
        {
            return childset.Count;
        }

        public bool IsLeaf()
        {
            if (childset.Count == 0)
            {
                return true;
            }
            return false;
        }

        public void AddChild(ITreeNode child)
        {
            childset.Add(child);
            child.SetParent(this);
        }

        public bool RemoveChild(ITreeNode child)
        {
            if (child == null)
            {
                return false;
            }
            childset.Remove(this);
            this.parent = null;
            return true;
        }
    }
}
