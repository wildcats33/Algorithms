/*

Given a Binary Tree:
     2
  1     7
8  3  6  9

Given an number, Find the parent. 
Input: 9 => Output: 7
Input: 1 ==> Output: 2
 */

 public Node FindParent(object value)
 {
    return FindParent(null, head, value);
 }

 public Node FindParent(Node parent, Node child, object value)
 {
     if(child == null)
     {
        return null;
     }

     if(child.Value.ComparetTo(value) == 0)
     {
         return parent;
     }

     var result = FindParent(child, child.Left, value);
     if(leftResult == null)
     {
        result = FindParent(child, child.Right, value);
     }

     return result;
 }