# Stack

## MyStackNode<T>

### Constructors:
Declaration | Description
------------|------------
`MyStackNode(T value)` | creates a stack node with a `value`

### Properties:

Name | Returned value | Settable | Notes
-----|----------------|----------|------
`T Data` | value stored in a node | Yes |
`MyStackNode<T> NextNode` | next node | Yes |

## MyStack<T>

### Constructors:
Declaration | Description
------------|------------
`MyStack()` | creates an empty queue
`MyStack(T value)` | creates a queue with a specified element
`MyStack(T[] elements)` | creates a queue based on array of elements

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Head` | first node of a Stack | Yes |

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Push(T element)` |  | O(1) | O(1) | pushes an element to stack
`T Pop()` | head of stack | O(1) | O(1) | deletes a head of stack
`T Peek()` | head of stack | O(1) | O(1) | does not delete a head of stack
`bool IsEmpty()` | true if stack is empty | O(1) | O(1) |

