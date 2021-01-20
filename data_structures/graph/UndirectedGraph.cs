using System;
using System.Collections.Generic;
using System.Linq;

namespace Structures
{
    class UndirectedGraph
    {
        Dictionary<int, List<(int Value, int Weight)>> elements = new Dictionary<int, List<(int Value, int Weight)>>();

        public UndirectedGraph() {}

        public UndirectedGraph(int element)
        {
            AddVertice(element);
        }

        public UndirectedGraph(int[,] neighborhoodMatrix)
        {

            for (int i = 0; i < neighborhoodMatrix.GetLength(0); ++i)
            {
                AddVertice(i);

                for(int j = 0; j < neighborhoodMatrix.GetLength(1); ++j)
                {
                    if(neighborhoodMatrix[i, j] != 0)
                    {
                        AddEdge(i, j, neighborhoodMatrix[i, j]);
                    }
                }
            }
        }

        public int[,] NeighbourhoodMatrix
        {
            get
            {
                int length = elements.Keys.Max();

                int[,] matrix = new int[length + 1, length + 1];

                foreach (var pair in elements)
                {
                    foreach(var (Value, Weight) in pair.Value)
                    {
                        matrix[pair.Key, Value] = Weight;
                    }
                }

                return matrix;
            }
        }

        public void AddEdge(int from, int to, int weight)
        {
            if (!elements.ContainsKey(from))
            {
                AddVertice(from);
            }

            elements[from].Add((to, weight));
        }

        public void AddVertice(int element)
        {
            var newEdgeList = new List<(int Value, int Weight)>();

            elements.Add(element, newEdgeList);
        }

        public List<int> BFSTraversal(int start)
        {
            Queue<int> tmpQueue = new Queue<int>();
            List<int> result = new List<int>();
            bool[] visited = new bool[elements.Keys.Count];

            tmpQueue.Enqueue(start);

            while (tmpQueue.Count > 0)
            {
                int actualItem = tmpQueue.Dequeue();

                if (visited[actualItem] == false)
                {
                    visited[actualItem] = true;
                    result.Add(actualItem);

                    foreach (var vertice in elements[actualItem])
                    {
                        tmpQueue.Enqueue(vertice.Value);
                    }
                }
            }

            return result;
        }

        public List<int> DFSTraversal(int start)
        {
            Stack<int> tmpQueue = new Stack<int>();
            List<int> result = new List<int>();
            bool[] visited = new bool[elements.Keys.Count];

            tmpQueue.Push(start);

            while (tmpQueue.Count > 0)
            {
                int actualItem = tmpQueue.Pop();

                if (visited[actualItem] == false)
                {
                    visited[actualItem] = true;
                    result.Add(actualItem);

                    List<(int Value, int Weight)> verticeList = elements[actualItem];
                    verticeList.Reverse();

                    foreach (var vertice in verticeList)
                    {
                        tmpQueue.Push(vertice.Value);
                    }
                }
            }

            return result;
        }

        public bool IsConnected()
        {
            return BFSTraversal(elements.Keys.FirstOrDefault()).Count == elements.Count;
        }

        public int[] Dijkstra(int start)
        {
            bool[] visited = new bool[elements.Count];
            int[] weights = new int[elements.Count];

            for(int i = 0; i < weights.Length; ++i)
            {
                weights[i] = int.MaxValue;
            }

            weights[start] = 0;
            visited[start] = true;

            //nadanie wag tras ze startu do sąsiedniego wierzchołka
            foreach(var item in elements[start])
            {
                if(visited[item.Value] == false)
                {
                    weights[item.Value] = item.Weight;
                }
            }

            for(int i = 1; i < elements.Count; ++i)
            {
                int lowestNotVisited = 0;

                //szukanie jakiegokolwiek nieodwiedzonego wierzchołka
                while (visited[lowestNotVisited] != false)
                {
                    lowestNotVisited++;
                }

                //wybranie nieodwiedzonego wierzchołka o najmniejszej wadze
                for(int j = 0; j < elements.Count; ++j)
                {
                    if(visited[j] == false && weights[j] < weights[lowestNotVisited])
                    {
                        lowestNotVisited = j;
                    }
                }

                //odwiedzamy wierzcholek o najmniejszej wadze
                visited[lowestNotVisited] = true;

                //uzupelniamy na liscie wagi tras do sasiednich wierzchołków
                foreach(var item in elements[lowestNotVisited])
                {
                    if(visited[item.Value] == false)
                    {
                        weights[item.Value] = Math.Min(weights[lowestNotVisited] + item.Weight, weights[item.Value]);
                    }
                }
            }

            return weights;
        }

        public UndirectedGraph Prim()
        {
            bool[] visited = new bool[elements.Count];
            int[] weights = new int[elements.Count];
            int[] parents = new int[elements.Count];

            for (int i = 0; i < elements.Count; ++i)
            {
                weights[i] = int.MaxValue;
                parents[i] = -1;
            }

            //int sum = 0;
            int startingElement = elements.First().Key;

            UndirectedGraph result = new UndirectedGraph(startingElement);

            weights[startingElement] = 0;
            visited[startingElement] = true;

            foreach(var vertice in elements[startingElement])
            {
                if(visited[vertice.Value] == false)
                {
                    weights[vertice.Value] = vertice.Weight;
                    parents[vertice.Value] = startingElement;
                }
            }

            for(int i = 1; i < elements.Count; ++i)
            {
                int lowestNotVisited = 0;

                //szukanie pierwszego nierozważonego wierzchołka
                while (visited[lowestNotVisited] != false)
                {
                    lowestNotVisited++;
                }

                //szukanie najbliższego nierozważonego wierzchołka
                for (int j = 0; j < elements.Count; ++j)
                {
                    if (visited[j] == false && weights[j] < weights[lowestNotVisited])
                    {
                        lowestNotVisited = j;
                    }
                }

                visited[lowestNotVisited] = true;
                //sum += weights[lowestNotVisited];

                foreach (var item in elements[lowestNotVisited])
                {
                    if (visited[item.Value] == false)
                    {
                        weights[item.Value] = Math.Min(item.Weight, weights[item.Value]);
                        parents[item.Value] = lowestNotVisited;
                    }
                }
            }

            for(int i = 1; i < elements.Count; ++i)
            {
                result.AddEdge(i, parents[i], weights[i]);
                result.AddEdge(parents[i], i, weights[i]); //wywalić jak graf jest skierowany
            }

            return result;
        }

        public UndirectedGraph Kruskal()
        {
            List<(int From, int To, int Weight)> edgesList = new List<(int From, int To, int Weight)>();
            List<(int From, int To, int Weight)> tree = new List<(int From, int To, int Weight)>();
            UnionFind<int> set = new UnionFind<int>();
            UnionFindNode<int>[] nodeArr = new UnionFindNode<int>[elements.Count];

            UndirectedGraph newGraph = new UndirectedGraph();

            foreach (var vertice in elements)
            {
                foreach(var edge in vertice.Value)
                {
                    edgesList.Add((vertice.Key, edge.Value, edge.Weight));
                }
            }

            edgesList = edgesList.OrderBy(element => element.Weight).ToList();

            for (int i = 0; i < elements.Count; ++i)
            {
                nodeArr[i] = new UnionFindNode<int>();
                nodeArr[i].Value = i;
                set.MakeSet(nodeArr[i]);
            }

            int edgeIndex = 0;
            int edges = 0;

            while (edges < elements.Count - 1)
            {
                UnionFindNode<int> node1 = null;
                UnionFindNode<int> node2 = null;

                for (int i = 0; i < nodeArr.Length; ++i)
                {
                    if (nodeArr[i].Value == edgesList[edgeIndex].From)
                    {
                        node1 = nodeArr[i];
                    }

                    if (nodeArr[i].Value == edgesList[edgeIndex].To)
                    {
                        node2 = nodeArr[i];
                    }
                }

                UnionFindNode<int> x = set.Find(node1);
                UnionFindNode<int> y = set.Find(node2);

                if (x != y)
                {
                    tree.Add(edgesList[edgeIndex]);
                    tree.Add((edgesList[edgeIndex].To, edgesList[edgeIndex].From, edgesList[edgeIndex].Weight)); //wywalić jak graf skierowany
                    edges++;

                    set.Union(x, y);
                }

                edgeIndex++;
            }

            foreach (var edge in tree)
            {
                newGraph.AddEdge(edge.From, edge.To, edge.Weight);
            }

            return newGraph;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var vertice in elements)
            {
                str += "L(" + vertice.Key + ") = {";

                foreach(var listItem in vertice.Value)
                {
                    str += "{" + listItem.Value + ", " + listItem.Weight + "}, ";
                }

                str += "}\n";
            }

            return str;
        }
    }
}
