/*
Give a Binary Tree. Let's assume that each Node in a Binary Tree is as follows:
class Node {
   Node left, right, nextSibling;
   int value;
}

Initially, left and right values are initialized but not the nextSibling. Fill in the nextSibling field:
Given a Binary Tree:
     2
  1     7
8  3  6  9

Output:
2 -> nextSibling = null
1 -> nextSibling = 7
7 -> nextSibling = null
3 -> nextSibling = 6
*/

public void SetNextSibling(Node parent) {
  if(node == null || node.Left == null && node.Right == null) {
    return;
  }

  Node nextSibling = null;
  Node nextSiblingOfParent = parent.NextSibling;
  while(nextSibling == null &&  nextSiblingOfParent != null) {
    if(nextSiblingOfParent.Left != null) {
      nextSibling = nextSiblingOfParent.Left;
    }
    else {
      nextSibling = nextSiblingOfParent.Right;
    }

    nextSiblingOfParent = nextSiblingOfParent.NextSibling;
  }


  if(parent.Left != null) {
    if(parent.Right != null) {
      parent.Left.NextSibling = parent.Right;
    }
    else {
      parent.Left.NextSibling = nextSibling;
    }
  }

  if(parent.Right !=  null) {
    parent.Right.NextSibling = nextSibling;
  }

  SetNextSibling(parent.Left);
  SetNextSibling(parent.Right);
}
