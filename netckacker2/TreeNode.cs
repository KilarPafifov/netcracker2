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
        private bool expanded = false;
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

        public ITreeNode FindChild(Object data)
        {
            foreach (ITreeNode node in childset)
            {
                if (node.GetData() != null)
                {
                    if (node.GetData().Equals(data))
                    {
                        return node;
                    }
                }

                else if (data == null)
                {
                    return node;
                }

                ITreeNode currentNode = node.FindChild(data);
                if(currentNode != null)
                {
                    return currentNode;
                }
            }
             
            return null;
        }

        public ITreeNode FindParent(Object data)
        {

            if ((this.data == null && data == null) || this.data.Equals(data))
            {
                return this;
            }

            if (parent == null)
            {
                return null;
            }

            return parent.FindParent(data);
        }

        public void SetExpanded(bool expanded)
        {
            this.expanded = expanded;

            foreach (TreeNode current in childset)
            {
                current.expanded = expanded;

                ITreeNode treeNode = current;
                if (treeNode != null)
                {
                    treeNode.SetExpanded(expanded);
                }
            }

        }
        public bool IsExpanded()
        {
            return expanded;
        }

     /*   public Enumerator<ITreeNode> GetChildrenIterator()
        {
            ITreeNode mmm = this;
            foreach(ITreeNode number in childset)
            {
                Console.WriteLine(number.ToString());
            }
            return mmm;
        }*/
    }
}
