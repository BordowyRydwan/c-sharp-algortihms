# Find & Union

A structure for disjoint sets.

## UnionFindNode<T>

### Properties:

Name | Returned value | Settable | Notes
-----|----------------|----------|------
`UnionFindNode<T> Parent` | parent node of a node | Yes |
`T Value` | value stored in a node | Yes |
`int Rank` | level of its presence in a tree | Yes |

## UnionFind<T>

alpha - symbol of inverse Ackermann function

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void MakeSet(UnionFindNode<T> UnionFindNode)` | tree written in bracket notation| O(log n) | O(1) | 
`UnionFindNode<T> Find(UnionFindNode<T> node)` | tree visualization on stdout | O(log n) | O(1) | 
`void Union(UnionFindNode<T> node1, UnionFindNode<T> node2)` | returns a searched node if present, null otherwise | O(m * alpha) | O(1) |


