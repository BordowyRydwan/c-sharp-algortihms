# Binary heap

## Constructors:
Declaration | Description
------------|------------
`Heap()` | creates an empty heap
`Heap(T element)` | creates a heap with 1 element
`Heap(T[] elements)` | creates a heap from elements of an array


## Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Height` | the node with the lowest key value in the tree | Yes | time - O(log n)

## Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Insert(T node)` | | O(log n) | O(1) | in average, it is O(1)
`void Heapify(int node)` | | O(log n) | O(1) | 
`void Build()` | | O(n log n) | O(1) | 
`void DeleteHighest()` | | O(1) | O(1) |
`int HowManyLeaves()` | number of leaves in a heap| O(n) | O(1) | 
`bool IsHeap()` | checks if a heap satisfies a heap condition | O(n) | O(1) |


