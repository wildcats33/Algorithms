/*
Construct a binary tree given inorder and postorder traversal outputs
           
            1
          /   \ 
        2       3
      /   \    /
    4       5 6

InOrder:  425163
PostOrder:452631                                                                                                                                                                                                                                                                          

****** Values have to be unique *************
*/

public Node BTreeFromInorderAndPostOrder(List<int> postOrder, List<int> inOrder)
{
    if(!postOrder.Any())
    {
      return null;
    }

    Node node = new Node(postOrder.Last());

    int index = inOrder.IndexOf(node.Value);    

    List<int> leftTree = inOrder.Take(index);
    List<int> rightTree = inOrder.Skip(index + 1).ToList();    

    node.Right = BTreeFromInorderAndPostOrder(postOrder.Skip(leftTree.Count).Take(rightTree.Count), rightTree);
    node.Left = BTreeFromInorderAndPostOrder(postOrder.Take(leftTree.Count), leftTree);
}


public Node BTreeFromInorderAndPostOrderOptimized(List<int> postOrder, int leftPostOrderIndex, int rightPostOrderIndex,
        List<int> inOrder, int leftInorderIndex, int rightInorderIndex)
{
    if(!postOrder.Any() || leftPostOrderIndex > rightPostOrderIndex)
    {
      return null;
    }

    Node node = new Node(postOrder[rightPostOrderIndex]);

    if(leftPostOrderIndex ==  rightPostOrderIndex)
    {
        return node;
    }

    int index = inOrder.IndexOf(node.Value);   

    int leftTreeLeftIndex = leftInorderIndex;
    int leftTreeRightIndex = index - 1;

    int rightTreeLeftIndex = index + 1;
    int rightTreeRightIndex = rightInorderIndex;

    int leftTreeCount = 0;
    if(leftTreeRightIndex > leftTreeLeftIndex)
      leftTreeCount = leftTreeRightIndex - leftTreeLeftIndex;

    int rightTreeCount = 0;
    if(rightTreeRightIndex > rightTreeLeftIndex)
      rightTreeCount = rightTreeRightIndex - rightTreeLeftIndex;  

    node.Left = BTreeFromInorderAndPostOrder(postOrder, leftPostOrderIndex , leftPostOrderIndex + leftTreeCount, inOrder, leftTreeLeftIndex, leftTreeRightIndex);
    node.Right = BTreeFromInorderAndPostOrder(postOrder, leftPostOrderIndex + leftTreeCount, leftPostOrderIndex + leftTreeCount + rightTreeCount, inOrder, rightTreeLeftIndex, rightTreeRightIndex);
}


