/*

Given a Binary Tree:
     2
  1     7
8  3  6  9

Given an number, Find the parent. 
Input: 9 => Output: 7
Input: 1 ==> Output: 2
 */

 public Node FindParent(int i)
 {
    return FindParent(null, head, i);
 }

 public Node FindParent(Node parent, Node child, int i)
 {
     if(child == null)
     {
        return null;
     }

     if(child.Value == i)
     {
         return parent;
     }

     var result = FindParent(child, child.Left, i);
     if(leftResult == null)
     {
        result = FindParent(child, child.Right, i);
     }

     return result;
 }