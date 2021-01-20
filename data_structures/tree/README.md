# Tree

*In computer science, a tree is a widely used abstract data type that simulates a hierarchical tree structure, with a root value and subtrees of children with a parent node, represented as a set of linked nodes.* ~Wikipedia

`T` is a generic type. `n` is amount of all of tree nodes.

## Node<T>

### Constructors:
Declaration | Description
------------|------------
`Node(T value)` | creates a node with specified `Value`

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Value` | value stored in a node | Yes |
`parent` | parent node | Yes |
`children` | a `List<T>` of node's children | Yes |

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void AddChild(T value)` | | O(1) | O(1) |
`void AddChildNode(Node<T> node)` | | O(1) | O(1) |
`bool IsRoot()` | true if a node hasn't its parent | O(1) | O(1) |
`static Node<T> FindNode(T searchedValue, Node<T> node)` | returns a searched node if present, null otherwise | O(nodeDepth) | O(1) |

## Tree<T>

### Constructors:
Declaration | Description
------------|------------
`Tree(T value)` | creates a tree with root of value: `value`
`Tree(Node<T> node)` | creates a tree with specific `node` assigned as a root
`Tree(string bracketTree)` | creates a node from tree written in bracket notation

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`root` | root of a tree | No |
`Depth` | depth/height of a tree | No | uses `DepthForNode(Node<T> node)`
`PreOrderTraversal` | a `List<T>` of node values in preorder traversal | No | time - O(n), memory - O(n)
`PostOrderTraversal` | a `List<T>` of node values in postorder traversal | No | time - O(n), memory - O(n)

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`int DepthForNode(Node<T> node)` | | O(log n) | O(1) |
`Node<T> FindNode(T value)` | a node of a specified value | O(1) | O(1) | uses `Node<T>.FindNode(T searchedValue, Node<T> node)`
`ToString()` | a tree in bracket notation | O(1) | O(1) | overrides `ToString()`

## TODO:
- [ ] translate the readme into Polish
- [ ] write unit tests


