# BST (Binary search tree)

Simply, it is a binary tree which for every node, its left direct child is lower than that node and for every node, its right direct child is bigger than that node.

`T` is a generic type. `n` is amount of all of tree nodes. This class derives from BinaryTree<\T> and has its methods and properties!


## Constructors:
Declaration | Description
------------|------------
`BST(T value)` | creates a BST with root of value: `value`
`BST(BinaryNode<T> node)` | creates a BST with specific `node` assigned as a root

## Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`MinElement` | the node with the lowest key value in the tree | Yes | time - O(n), for balanced tree O(log n)
`MaxElement` | the node with the highest key value in the tree | Yes | time - O(n), for balanced tree O(log n)

## Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Insert(T value)` | | O(n) | O(1) | time - O(log n) if tree is balanced
`void Insert(BinaryNode<T> node)` | | O(n) | O(1) | time - O(log n) if tree is balanced
`void Delete(T value)` | | O(n) | O(1) | time - O(log n) if tree is balanced
`void Delete(BinaryNode<T> node)` | | O(n) | O(1) | time - O(log n) if tree is balanced
`bool[] GetPathTo(T value)` | bool[] representing path to searched node | O(n) | O(1) | time - O(log n) if tree is balanced
`void RotateLeft(BinaryNode<T> node)` | | O(1) | O(1) | 
`void RotateRight(BinaryNode<T> node)` | | O(1) | O(1) | 
`void Balance()` | | O(n) | O(1) | 
`BinaryNode<T> Successor(BinaryNode<T> node)` | successor node (in in-order traversal) for specified node | O(n) | O(1) | time - O(log n) if tree is balanced
`BinaryNode<T> Decessor(BinaryNode<T> node)` | decessor node (in in-order traversal) for specified node | O(n) | O(1) | time - O(log n) if tree is balanced

## TODO:
- [ ] translate the readme into Polish
- [ ] write unit tests


