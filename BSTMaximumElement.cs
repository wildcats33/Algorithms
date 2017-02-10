
/*
        5
      /   \
     1     3
    / \   / \
   7   8  2  9


Question 1. Find the max element in the binary tree.
*/
int Maximum(Node n)
{
    if(n == null) {
        return Int32.MinValue;
    }

    int maxLeft = Maximum(n.Left);
    int maxRight = Maximum(n.Right);

    int max = n.Value;
    if(n.Value < maxLeft) {
        max = maxLeft;
    }

    if(n.Value < maxRight) {
        max = maxRight;
    }

    return max;
}
