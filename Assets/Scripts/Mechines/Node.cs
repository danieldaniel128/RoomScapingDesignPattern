using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Node
{
    public Node Parent;
    public List<Node> Children = new List<Node>();

    private bool value = false;

    public Node() { }

    public Node CreateChild()
    {
        Node child = new Node();
        child.Parent = this;
        Children.Add(child);
        return child;
    }


    public void SetValue(bool value)
    {
        this.value = value;
    }

    public bool GetValue()
    {
        if (Children == null || Children.Count == 0)
        {
            return value;
        }

        foreach (var child in Children)
        {
            if (!child.GetValue())
            {
                return false;
            }
        }
        return true;
    }
}
