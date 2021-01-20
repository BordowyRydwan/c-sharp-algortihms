# Queue (based on linked list)

## MyQueueNode<T>

### Constructors:
Declaration | Description
------------|------------
`MyQueueNode(T value)` | creates a queue node with a `value`

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`T Data` | value stored in a node | Yes |
`MyQueueNode<T> NextNode` | next node | Yes |

## BinaryTree<T>

### Constructors:
Declaration | Description
------------|------------
`MyQueue()` | creates an empty queue
`MyQueue(T value)` | creates a queue with a specified element
`MyQueue(T[] elements)` | creates a queue based on array of elements

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Head` | first node of a FIFO queue | Yes |

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Enqueue(T element)` | tree written in bracket notation | O(n) | O(1) | 
`T Dequeue()` | returns a first element of queue and deletes it | O(1) | O(1) | 
`T Peek()` | returns a first element of queue and does not delete it | O(1) | O(1) | 
`bool IsEmpty()` | check if a queue is empty | O(1) | O(1)

