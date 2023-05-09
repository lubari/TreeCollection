using System.Collections;

namespace TreeCollection
{
    public class Tree<T> : IEnumerable<T> 
    {
        private Node root;
        public Tree(bool isReversed = false) 
        {
            throw new NotImplementedException();
        }
        
        public void CreateTree(){
            this.root = new Node();
        }

        public void Add(T newElement)
        {
            if (this.root == null)
            {
                this.root = new Node();
                this.root.value = newElement;
            }
            
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        private class Node
        {   
            public Object? value;
            public Object? right;
            public Object? left;
        }
    }
}