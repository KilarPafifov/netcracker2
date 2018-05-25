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
        public ITreeNode GetRoot()
        {
            
            if (this.parent == null)
            {
                return this;
            }

            ITreeNode currentNode = this;

            while (currentNode.GetParent() != null)
            {
                currentNode = currentNode.GetParent();
            }
            
            return currentNode;
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
            if (!childset.Contains(child))
            {
                return false;
            }
            childset.Remove(child);
            child.SetParent(null);
            return true;
        }

        public String GetTreePath()
        {
            ITreeNode currentNode = this;
            String output = "empty";

            while (currentNode != null)
            {
                output += "<-" + Convert.ToString(currentNode.GetData());
                currentNode = currentNode.GetParent();
            }

            return output;
        }

        public ITreeNode FindChild(object data)
        {
            throw new NotImplementedException();
        }

        public ITreeNode FindParent(Object data)
        {
            ITreeNode currentNode = this;

            while (currentNode != null)
            {
                if (currentNode.GetData().Equals(data))
                {
                    return currentNode;
                }
                currentNode = currentNode.GetParent();
            }
            return null;
        }

        public void SetExpanded(bool expanded)
        {
            throw new NotImplementedException();
        }

        public bool IsExpanded()
        {
            throw new NotImplementedException();
        }
    }
}
