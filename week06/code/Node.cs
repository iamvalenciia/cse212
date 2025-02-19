public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        // Skip insertion if the value already equals the current node's data
        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // If current node matches the value we're looking for
        if (value == Data)
            return true;
            
        // If value is less than current node, check left subtree
        if (value < Data)
        {
            // Return false if no left child exists
            if (Left == null)
                return false;
            // Recursively check left subtree
            return Left.Contains(value);
        }
        else
        {
            // Return false if no right child exists
            if (Right == null)
                return false;
            // Recursively check right subtree
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        // Base case: current node is the root of this subtree
        int leftHeight = 0;
        int rightHeight = 0;
        
        // Recursively get the height of left subtree
        if (Left != null)
            leftHeight = Left.GetHeight();
            
        // Recursively get the height of right subtree
        if (Right != null)
            rightHeight = Right.GetHeight();
            
        // Height is 1 (for this node) plus the maximum height of either subtree
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}