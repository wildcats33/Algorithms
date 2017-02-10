Question 3. Find the path from root to leaf, which has minimum distance. (5, 3, 2)


public class LinkedListNode {
    public Node node { get; }
    public LinkedListNode nextLinkedListNode { get; }

    public LinkedListNode(Node node, LinkedListNode nextLinkedListNode) {
        this.node = node;
        this.nextLinkedListNode = nextLinkedListNode;
    }
}

public class Result: IComparable<Result>
{
    public LinkedListNode LinkedListNode { get; set;}

    public int Sum { get; set; }

    public Result(Result result, Node n)
    {
        this.LinkedListNode = new LinkedListNode(n, result.LinkedListNode);
        this.Sum = n.Value + result.Sum;
    }

    int CompareTo(Result other)
    {
       return this.Sum - other.Sum;
    }

    public Result()
    {
        Sum = 0;
    }
}

public Result PathFromRootToLeaf(Node n)
{
    if(n == null) {
        return new Result();
    }

    Result leftResult = PathFromRootToLeaf(n.Left);
    Result rightResult = PathFromRootToLeaf(n.Right);

    return (leftResult.CompareTo(rightResult) > 0) ?
        new Result(rightResult, n) :
        new Result(leftResult, n);
}
