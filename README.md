![Algorithms and data structures](top_banner.png)

# C# Algorithms

This repo is an extension of [algorithms-and-data-structures](https://github.com/BordowyRydwan/algorithms-and-data-structures) repo. It contains algorithms from lectures rewritten in quite more understandable way. Feel free to use the code - just remember to read the code that you wanna use - it might e.g. use other data structues than you need.

Link to **Polish README:** [HERE](README_PL.md)

##  List of algorithms

### Algebra

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Binomial coefficient](/algorithms/algebra/binomial_coefficient) | O(n) | O(1) |
[Prime numbers lower than N](algorithms/algebra/erathostenes_sieve) | O(n^2) | O(n) |
[Prime test](/algorithms/algebra/erathostenes_sieve) | O(n) | O(1) |
[Fibonacci sequence](/algorithms/algebra/fibonacci_seq) (dynamic) | O(n) | O(n)| 
[Fibonacci sequence](/algorithms/algebra/fibonacci_seq) (others) | O(n) | O(1) |
[Greatest Common Divisor (GCD)](/algorithms/algebra/gcd_lcm) | O(n) | O(1) |
[Least Common Multiplier (LCD)](/algorithms/algebra/gcd_lcm) | O(n) | O(1) |
[Quick Powering](/algorithms/algebra/quick_power) | O(n) | O(1) |
[Square root](/algorithms/algebra/square_root) (Newton - Rawson) | O(n) | O(1) |

### Combinatorics

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Coin change problem](/algorithms/combinatorics/giving_change) (ways) | O(n^2) | O(n)  |
[Coin change problem](/algorithms/combinatorics/giving_change) (min coins) | O(n) | O(n)  |
[Index sum](/algorithms/combinatorics/index_sum) | O(n) | O(1)  | input needs to be sorted
[Knapsack problem](/algorithms/combinatorics/knapsack_problem) (max value) | O(n^2) | O(n^2)  |
[Knapsack problem](/algorithms/combinatorics/knapsack_problem) (find items) | O(n^2) | O(n^2)  |
[Master element](/algorithms/combinatorics/master_element) | O(n) | O(1)  | input needs to be sorted
[Separate tasks problem](/algorithms/combinatorics/separated_tasks_problem) | O(n^2) | O(n)  | 

### Searching

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Linear search](/algorithms/searching/linear_search) | O(n) | O(1)  |
[Binary search](/algorithms/searching/binary_search) | O(log(n)) | O(1)  | input needs to be sorted
[Ternary search](/algorithms/searching/ternary_search) | O(log(n)) | O(1)  | input needs to be sorted

### Sorting

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Bubble sort](/algorithms/sorting/bubble_sort) | O(n^2) | O(1)  |
[Insertion sort](/algorithms/sorting/insertion_sort) | O(n^2) | O(1)  |
[Selection sort](/algorithms/sorting/seleciton_sort) | O(n^2) | O(1)  |
[Merge sort](/algorithms/sorting/merge_sort) | O(n * log(n)) | O(n)  |
[Quick sort](/algorithms/sorting/quick_sort) | O(n * log(n)) | O(log(n))  |
[Counting sort](/algorithms/sorting/count_sort) | O(n + r) | O(n + r)  |
[Radix sort](/algorithms/sorting/radix_sort) | O(n * k) | O(n + k)  |
[Queue sort](/algorithms/sorting/queue_sort) | O(n^2) | O(n)  |
[Flag problem](/algorithms/sorting/flag_problem) | O(n) | O(1)  |

### Text

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Longest common subsequence](/algorithms/text/lcs) | O(n^2) | O(n^2)  | 


### Graph

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[BFS Traversal](/data_structures/graph) | O(V + E) | O(V)  | 
[DFS Traversal](/data_structures/graph) | O(V + E) | O(V) | 
[Checking if all vertices are connected](/data_structures/graph)  | O(V + E) | O(V) | 
[Dijkstra's algorithm](/data_structures/graph) | O(V^2) | O(V) | 
[Prim's algorithm](/data_structures/graph)  | O(E * log(V)) | O(V) | 
[Kruskal's algorithm](/data_structures/graph)  | O(E * log(E)) | O(V + E) | uses my [UnionFind<T>](../union_find)

### Binary search tree

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Insert a node](/data_structures/bst) | O(n) | O(1)  | time - O(log n) if tree is balanced
[Deleting a node](/data_structures/bst) | O(n) | O(1) | time - O(log n) if tree is balanced
[Balancing a tree](/data_structures/bst)  | O(n) | O(1) | time - O(log n) if tree is balanced
[Left/right rotate of a node](/data_structures/bst) | O(1) | O(1) | 
[Finding node's decessor](/data_structures/bst)  | O(E * log(V)) | O(1) | time - O(log n) if tree is balanced
[Finding node's successor](/data_structures/bst)  | O(E * log(E)) | O(1) | time - O(log n) if tree is balanced

## Heap

Name | Time complexity | Memory stack size  | Notes
-----| ----------------| -----------------  | -----
[Insert a node](/data_structures/heap) | O(log n) | O(1) | average - O(1)
[Repair a heap](/data_structures/heap) | O(log n) | O(1) | 
[Build a heap](/data_structures/heap) | O(n log n) | O(1) | 
[Counting heap's leaves](/data_structures/heap) | O(log n) | O(1) | 
[Deleting highest element](/data_structures/heap) | O(1) | O(1) |

Operations on data structues weren't mostly considered as algorithms and are described somewhere [HERE](/data_structures).

## Data structures

- [Binary tree](/data_structures/array_binary_tree) (array implementation)
- [Binary tree](/data_structures/binary_tree) (node implementation)
- [Binary search tree (BST)](/data_structures/bst)
- [Find & Union](/data_structures/union_find) 
- [Graph](/data_structures/graph) 
- [Heap](/data_structures/heap) 
- [List](/data_structures/list) 
- [Queue](/data_structures/queue) 
- [Set](/data_structures/set) (List and Hashtable implementations)
- [Stack](/data_structures/stack) 
- [Tree](/data_structures/tree) 
