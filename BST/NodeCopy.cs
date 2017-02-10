public Node copy(Node root) {
    if(root == null)
        return null;

    Node node = new Node(root.Value);
    node.Left = copy(root.Left);
    node.Right = copy(root.Right);

    return node;
}
