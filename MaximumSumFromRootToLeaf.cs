// This is post order traversal
public int MaximumSumFromRootToLeaf(Node n)
{
    if(n == null) {
        return 0;
    }

    readonly int maximumLeft = MaximumSumFromRootToLeaf(n.Left);
    readonly int maximumRight = MaximumSumFromRootToLeaf(n.Right);

    return n.Value + ((maximumLeft > maximumRight) ?  + maximumLeft : maximumRight);
}
 
