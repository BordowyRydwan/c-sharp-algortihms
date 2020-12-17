# Binary tree

*In computer science, a binary tree is a tree data structure in which each node has at most two children, which are referred to as the left child and the right child. A recursive definition using just set theory notions is that a (non-empty) binary tree is a tuple (L, S, R), where L and R are binary trees or the empty set and S is a singleton set containing the root. Some authors allow the binary tree to be the empty set as well.* ~Wikipedia

`T` is a generic type. `n` is amount of all of tree nodes.

## BinaryNode<T>

### Constructors:
Declaration | Description
------------|------------
`BinaryNode(T value)` | creates a node with specified `Value` and sets children to null

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Value` | value stored in a node | Yes |
`Parent` | parent node | Yes |
`Left` | left node | Yes |
`Right` | right node | Yes |
`Weight` | a weight of a tree | Node | time - O(n), memory stack size O(log n)

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`static BinaryNode<T> FindNode(T searchedValue, BinaryNode<T> node)` | returns a searched node if present, null otherwise | O(n) | O(1) |

## BinaryTree<T>

### Constructors:
Declaration | Description
------------|------------
`BinaryTree(T value)` | creates a tree with root of value: `value`
`BinaryTree(BinaryNode<T> node)` | creates a tree with specific `node` assigned as a root

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Root` | root of a tree | Yes |
`Depth` | depth/height of a tree | No | time - O(log n)
`Weight` | weight of a root node | No | time - O(n), memory - O(n)
`PostOrderTraversal` | a `List<T>` of node values in postorder traversal | No | time - O(n), memory - O(n)
`PreOrderTraversal` | a `List<T>` of node values in preorder traversal | No | time - O(n), memory - O(n)
`InOrderTraversal` | a `List<T>` of node values in inorder traversal | No | time - O(n), memory - O(n)

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`string ToBracket()` | tree written in bracket notation| O(n) | O(n) | 
`void PrintTree()` | tree visualization on stdout | O(n) | O(n) | you need to move your head 90 deg left to see it :)
`Node<T> FindNode(T value)` | returns a searched node if present, null otherwise | O(1) | O(1) | uses `Node<T>.FindNode(T searchedValue, Node<T> node)`
`BinaryNode<T> GetNodeByPath(bool[] path)` | returns a node with specified path | O(log n) | O(log n)

## TODO:
- [ ] translate the readme into Polish
- [ ] write unit tests


