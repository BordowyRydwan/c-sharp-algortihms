# List

## MyListNode<T>

### Constructors:
Declaration | Description
------------|------------
`MyListNode(T value)` | creates a list node with a `value`

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`T Data` | value stored in a node | Yes |
`MyListNode<T> PreviousNode` | previous node | Yes |
`MyListNode<T> NextNode` | next node | Yes |

## MyList<T>

### Constructors:
Declaration | Description
------------|------------
`MyList()` | creates an empty list
`MyList(T value)` | creates a list with a specified element
`MyList(T[] elements)` | creates a list based on array of elements

### Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`Head` | first node of a list | Yes |
`Count` | length of a list | No |
`Rear` | last element of list | No |
`Front` | first element of list | No |

### Indexer:
Purpose | Returned value  | Notes
-----|----------|------
getter | a list index of specified number |
setter | updates a value of node of index with specified number |

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Insert(T element, int index)` |  | O(n) | O(1) | inserts an element without destroying others
`void Eject()` | | O(n) | O(1) | deletes last element of list
`void Pop()` | | O(1) | O(1) | deletes first element of list
`void Inject(T element)` | | O(n) | O(1) | adds an element to end of list
`void Push(T element)` | | O(1) | O(1) | adds an element to start of list
`int Search(T entry)` | index of a saerched element | O(n) | O(1) | -1 if not found
`static MyList<T> Concat(MyList<T> list1, MyList<T> list2)` | list from 2 connected lists | O(n) | O(1)
`MyList<T> Slice(int startIndex, int endIndex)` | a list of elements from a specified index to another one | O(list1.Count + list2.Count) | O(1)

