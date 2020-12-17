# Array Binary Tree

*In computer science, a binary tree is a tree data structure in which each node has at most two children, which are referred to as the left child and the right child. A recursive definition using just set theory notions is that a (non-empty) binary tree is a tuple (L, S, R), where L and R are binary trees or the empty set and S is a singleton set containing the root. Some authors allow the binary tree to be the empty set as well.* ~Wikipedia

`T` is a generic type. `n` is amount of all of tree nodes.

## Constructors:
Declaration | Description
------------|------------
`ArrayBinaryTree()` | creates empty binary tree
`ArrayBinaryTree(T value)` | creates a binary tree including a root with key `value`
`ArrayBinaryTree(T[] values)`| creates a whole structure of binary tree from an array
`ArrayBinaryTree(List<T> values) `| creates a whole structure of binary tree from a list

## Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Root` | root of the binary tree | Yes |
`Height` | height/depth of the tree | No |

## Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`bool Exists(T value)` | true if value exists in a tree, false otherwise | O(n) | O(1)|
`T GetParentOf(int index)` | a parent of the node with index in argument | O(1) | O(1)|
`int GetParentIndexOf(int index)` | index of node parent with index in argument | O(1) | O(1)|
`void SetParentOf(int index, T value)` | | O(1) | O(1) | resizes a tree array, sets parent value
`T GetLeftOf(int index)` | a left child of the node with index in argument | O(1) | O(1)|
`int GetLeftIndexOf(int index)` | index of node's left child with index in argument | O(1) | O(1)|
`void SetLeftOf(int index, T value)` | | O(1) | O(1) | resizes a tree array, set node's left child value
`T GetRightOf(int index)` | a right child of the node with index in argument | O(1) | O(1)|
`int GetRightIndexOf(int index)` | index of node's right child with index in argument | O(1) | O(1)|
`void SetRightOf(int index, T value)` | | O(1) | O(1) | resizes a tree array, set node's right child value
`T GetElementFromPath(bool[] path)` | returns a value of element having a specified search path | O(log n) | O(log n) | a path is array of booleans representing left-right decisions - left is false, right is true
`int GetIndexElementFromPath(bool[] path)` | returns index of a value of element having a specified search path | O(log n) | O(log n) | a path is array of booleans representing left-right decisions - left is false, right is true


## TODO:
- [ ] translate the readme into Polish
- [ ] write unit tests
- [ ] write methods for postorder, preorder and inorder traversal

