# Graph (undirected)

My graph is implemented on adjacence lists.

## Constructors:
Declaration | Description
------------|------------
`UndirectedGraph()` | creates an empty graph
`UndirectedGraph(int element)` | creates a graph with one vertice
`UndirectedGraph(int[,] neighborhoodMatrix)` | creates a graph from a adjacence matrix

## Properties:
Name | Returned value | Settable | Notes
-----|----------------|----------|------
`NeighborhoodMatrix` | the node with the lowest key value in the tree | Yes | time - O(n), for balanced tree O(log n)

## Methods:

Declaration | Returned value | Time complexity | Memory complexity | Notes
------------|----------------|-----------------|-------------------|------
`void AddEdge(int from, int to, int weight)` | | O(1) | O(1) | 
`void AddVertice(int element)` | | O(1) | O(1) | 
`List<int> BFSTraversal(int start)` | `List<int>` of elements passed with BFS method | O(V + E) | O(V) | 
`List<int> DFSTraversal(int start)` | `List<int>` of elements passed with DFS method | O(V + E) | O(V) | 
`bool IsConnected()` | checks if all vertices are connected | O(V + E) | O(V) | 
`int[] Dijkstra(int start)` | array of shortest path from start to all other vertices | O(V^2) | O(V) | 
`UndirectedGraph Prim()` | a graph of minimum spanning tree | O(E * log(V)) | O(V) | 
`UndirectedGraph Kruskal()` | a graph of minimum spanning tree | O(E * log(E)) | O(V + E) | uses my [UnionFind<T>](../union_find)


