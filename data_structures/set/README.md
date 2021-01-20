# Set

## HashMapSet

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Add(Object value)` | | O(1) | O(1) | adds an element to a set
`void Remove(Object key)` | | O(1) | O(1) | removes an element from a set
`bool Contains(Object key)` | | O(1) | O(1) | checks if element contains a specified key
`static HashMapSet Intersection(HashMapSet set1, HashMapSet set2)` | a set of intersection of `set1` and `set2` | O(set1.Length) | O(1) |
`static HashMapSet Sum(HashMapSet set1, HashMapSet set2)` | a set of sum of `set1` and `set2` | O(set1.Length + set2.Length) | O(n) |
`static HashMapSet Difference(HashMapSet set1, HashMapSet set2)` | a set of difference of `set1` and `set2` | O(set2.Length) | O(1) |

## ListSet<T> (uses a [MyList<T>](../list))

### Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void Add(Object value)` | | O(n) | O(1) | adds an element to a set
`void Remove(Object key)` | | O(n) | O(1) | removes an element from a set
`bool Contains(Object key)` | | O(n) | O(1) | checks if element contains a specified key
`static ListSet<T> Intersection(ListSet<T> set1, ListSet<T> set2)` | a set of intersection of `set1` and `set2` | O(n^2) | O(1) |
`static ListSet<T> Sum(ListSet<T> set1, ListSet<T> set2)` | a set of sum of `set1` and `set2` | O(n^2) | O(n) |
`static ListSet<T> Difference(ListSet<T> set1, ListSet<T> set2)` | a set of difference of `set1` and `set2` | O(n) | O(1) |



