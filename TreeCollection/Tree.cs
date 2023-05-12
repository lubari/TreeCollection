using System.Collections;

namespace TreeCollection
{
    public class Tree<T> : IEnumerable<T> 
    {private class TreeNode<T>
        {
            public T Value;
            public TreeNode<T> Left;
            public TreeNode<T> Right;
        }

        private TreeNode<T> root;
        private bool isReversed;

        public Tree(bool isReversed = false) 
        {
            root = null;
            this.isReversed = isReversed;
        }

        public void Add(T newElement)
        {
            if (root == null) 
            {
                root = new TreeNode<T> { Value = newElement };
            } 
            else 
            {
                TreeNode<T> currentNode = root;
                while (true) 
                {
                    int comparisonResult = Comparer<T>.Default.Compare(newElement, currentNode.Value);
                    if (comparisonResult == 0) 
                    {
                        throw new ArgumentException("Element already exists in the tree.");
                    } 
                    else if (comparisonResult < 0) 
                    {
                        if (currentNode.Left == null) 
                        {
                            currentNode.Left = new TreeNode<T> { Value = newElement };
                            break;
                        } 
                        else 
                        {
                            currentNode = currentNode.Left;
                        }
                    } 
                    else 
                    {
                        if (currentNode.Right == null) 
                        {
                            currentNode.Right = new TreeNode<T> { Value = newElement };
                            break;
                        } 
                        else 
                        {
                            currentNode = currentNode.Right;
                        }
                    }
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            if (root == null) 
            {
                yield break;
            }

            if (isReversed) 
            {
                foreach (T value in ReverseInOrderTraversal(root)) 
                {
                    yield return value;
                }
            } 
            else 
            {
                foreach (T value in InOrderTraversal(root)) 
                {
                    yield return value;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private IEnumerable<T> InOrderTraversal(TreeNode<T> node)
        {
            if (node.Left != null) 
            {
                foreach (T value in InOrderTraversal(node.Left)) 
                {
                    yield return value;
                }
            }

            yield return node.Value;

            if (node.Right != null) 
            {
                foreach (T value in InOrderTraversal(node.Right)) 
                {
                    yield return value;
                }
            }
        }

        private IEnumerable<T> ReverseInOrderTraversal(TreeNode<T> node)
        {
            if (node.Right != null) 
            {
                foreach (T value in ReverseInOrderTraversal(node.Right)) 
                {
                    yield return value;
                }
            }

            yield return node.Value;

            if (node.Left != null) 
            {
                foreach (T value in ReverseInOrderTraversal(node.Left)) 
                {
                    yield return value;
                }
            }
        }
    }
}