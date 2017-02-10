//Question 3. Find the path from root to leaf, which has minimum distance. (5, 3, 2)

public class Result: IComparable<Result>
{
    public List<Node> MinPathNodes { get; set;}

    public int Sum { get; set; }

    public Result(Result result, Node n)
    {
        this.MinPathNodes = new List<Node> { n };
        this.MinPathNodes.AddRange(result.MinPathNodes);
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
