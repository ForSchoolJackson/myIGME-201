using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EXAM_problem_3
{

    public enum EColors
    {
        Red,
        Blue,
        Grey,
        Cyan,
        Orange,
        Yellow,
        Purple,
        Green
    }

    public class Node : IComparable<Node>
    {
        public EColors eColor;

        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(EColors eColor)
        {
            this.eColor = eColor;
            this.minCostToStart = int.MaxValue;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }

    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }

    //program class
    internal class Program
    {

        static int[,] mGraph = new int[,]
       {
                     // Red  Blue    Grey  Cyan   Orange Yellow   Purple  Green
            /* Red */ { -1     , 1    , 5   , -1   , -1   , -1   , -1   , -1 },
            /* Blue */ { -1     , -1   , -1   , 1  , -1   , 8   , -1   , -1 },
            /* Grey */ { -1    , -1     , -1   , 0   , 1  , -1  , -1  , -1},
            /* Cyan */ { -1     , 1     , 0  , -1  , -1  ,-1   ,-1    ,-1 },
            /* Orange */ { -1   , -1   , -1  ,-1   ,-1   , -1   , 1   , -1 },
            /* Yellow */ { -1   , -1   , -1  ,-1   ,-1   , -1   , -1   , 6 },
            /* Purple */ { -1   , -1   , -1  ,-1   ,-1   , 1   , -1   , -1 },
            /* Green */ { -1    , -1   , -1  , -1  , -1  , -1  , -1   , -1 }
       };

        static EColors[][] lGraph = new EColors[][] {

                       
    /* RED */    new EColors[] { EColors.Blue, EColors.Grey },
    /* BLUE */   new EColors[] { EColors.Cyan, EColors.Yellow },
    /* GRAY */   new EColors[] { EColors.Cyan, EColors.Orange },
    /* CYAN */   new EColors[] { EColors.Blue, EColors.Grey },
    /* ORANGE */ new EColors[] { EColors.Purple },
    /* YELLOW */ new EColors[] { EColors.Green },
    /* PURPLE */ new EColors[] { EColors.Yellow },
    /* GREEN */  new EColors[0] 
};

        static int[][] wGraph = new int[][]
{                          // Red  Blue    Grey  Cyan   Orange  Yellow   Purple  Green
    /* RED */    new int[] { -1,    1,     5,    -1,     -1,     -1,      -1,    -1 },
    /* BLUE */   new int[] { -1,   -1,      -1,    1,    -1,     8,       -1,    -1 },
    /* GRAY */   new int[] { -1,    -1,     -1,     0,   1,      -1,      -1,    -1 },
    /* CYAN */   new int[] { -1   , 1,     1,     -1,    -1,    -1,      -1,    -1 },
    /* ORANGE */ new int[] { -1,   -1,    -1,    -1,    -1,    -1,        1,      -1 },
     /* YELLOW */ new int[] { -1,    -1,    -1,   -1,    -1,    -1,       -1,      6  },
    /* PURPLE */ new int[] { -1   , -1,    -1,    -1,     -1,    1,      -1,    -1 },
    /* GREEN */  new int[] { -1,   -1,   -1,       -1,   -1,     -1,   -1,      -1 }
};

        static int nState = 0;

        static List<Node> graph = new List<Node>();

        static void Main(string[] args)
        {
            Random rand = new Random();


            Node node;
            node = new Node(EColors.Red);
            graph.Add(node);

            node = new Node(EColors.Blue);
            graph.Add(node);


            node = new Node(EColors.Grey);
            graph.Add(node);


            node = new Node(EColors.Cyan);
            graph.Add(node);

            node = new Node(EColors.Orange);
            graph.Add(node);

            node = new Node(EColors.Yellow);
            graph.Add(node);

            node = new Node(EColors.Purple);
            graph.Add(node);

            node = new Node(EColors.Green);
            graph.Add(node);

            graph[(int)EColors.Red].AddEdge(1, graph[(int)EColors.Blue]);
            graph[(int)EColors.Red].AddEdge(5, graph[(int)EColors.Grey]);
            graph[(int)EColors.Red].edges.Sort();

            graph[(int)EColors.Blue].AddEdge(1, graph[(int)EColors.Cyan]);
            graph[(int)EColors.Blue].AddEdge(8, graph[(int)EColors.Yellow]);
            graph[(int)EColors.Blue].edges.Sort();

            graph[(int)EColors.Grey].AddEdge(0, graph[(int)EColors.Cyan]);
            graph[(int)EColors.Grey].AddEdge(1, graph[(int)EColors.Orange]);
            graph[(int)EColors.Grey].edges.Sort();

            graph[(int)EColors.Grey].AddEdge(0, graph[(int)EColors.Cyan]);
            graph[(int)EColors.Grey].AddEdge(1, graph[(int)EColors.Orange]);
            graph[(int)EColors.Grey].edges.Sort();

            graph[(int)EColors.Cyan].AddEdge(1, graph[(int)EColors.Blue]);
            graph[(int)EColors.Cyan].AddEdge(1, graph[(int)EColors.Grey]);
            graph[(int)EColors.Cyan].edges.Sort();

            graph[(int)EColors.Orange].AddEdge(1, graph[(int)EColors.Purple]);
            graph[(int)EColors.Orange].edges.Sort();

            graph[(int)EColors.Yellow].AddEdge(6, graph[(int)EColors.Green]);
            graph[(int)EColors.Yellow].edges.Sort();

            graph[(int)EColors.Purple].AddEdge(1, graph[(int)EColors.Yellow]);
            graph[(int)EColors.Purple].edges.Sort();

            //shortest path
            List<Node> shortestPath = GetShortestPathDijkstra();

            while (true)
            {
                nState = rand.Next(0, Enum.GetNames(typeof(EColors)).Length);

                if (nState != (int)EColors.Green)
                {
                    break;
                }
            }

            Console.WriteLine("Dijkstra's Shortest Path:");
            for (int i = 0; i < shortestPath.Count; i++)
            {
                Console.WriteLine(shortestPath[i].eColor);
            }

            //dfs
            Thread t = new Thread(DFS);
            t.Start();

        }

        //FOR QUESTION 4
        static void DFS()
        {
            bool[] visited = new bool[lGraph.Length];

            Console.WriteLine("Depth First Search:");

            for (int i = 0; i < lGraph.Length; i++)
            {
                if (!visited[i])
                {
                    DFSUtil((EColors)i, visited);
                }
            }
        }

        static void DFSUtil(EColors v, bool[] visited)
        {
            visited[(int)v] = true;

            Console.WriteLine(v.ToString() + " ");

            for (int i = 0; i < mGraph.GetLength(1); i++)
            {
                if (mGraph[(int)v, i] != -1 && !visited[i])
                {
                    DFSUtil((EColors)i, visited);
                }
            }
        }

        //FOR QUESTION 5
        static public List<Node> GetShortestPathDijkstra()
        {
            // traverse the path and calculate the minCostToStart and nearestToStart
            DijkstraSearch();

            List<Node> shortestPath = new List<Node>();

            // start from the end
            shortestPath.Add(graph[(int)EColors.Green]);

            // recursively traverse from finish to start
            BuildShortestPath(shortestPath, graph[(int)EColors.Green]);

            // reverse the path
            shortestPath.Reverse();

            // return the shortest path
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }


        static int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = graph[(int)EColors.Red];

            start.minCostToStart = 0;

            List<Node> queue = new List<Node>();
            queue.Add(start);

            // 2 ways to point our delegate variable to a delegate method
            Func<Node, int> nodeOrderBy = new Func<Node, int>(NodeOrderBy);
            //Func<Node, int> nodeOrderBy = NodeOrderBy;

            // stay in this loop while we have items in our queue
            do
            {
                // sort our queue by minCostToStart
                // option #1, use .Sort() which sorts in place
                queue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // the next 5 lines are equivalent from descriptive to abbreviated:
                queue = queue.OrderBy(nodeOrderBy).ToList();
                queue = queue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                queue = queue.OrderBy((n) => n.minCostToStart).ToList();
                queue = queue.OrderBy(n => n.minCostToStart).ToList();

                // grab the first node from our sorted queue
                Node node = queue.First();

                // remove it
                queue.Remove(node);

                // look at each edge and calculate the minCostToStart for each neighbor
                foreach (Edge cnn in node.edges)
                {
                    Node neighborNode = cnn.connectedNode;

                    if (neighborNode.visited)
                    {
                        continue;
                    }

                    // check if the path from this neighbor to the start is shorter if passing through this node
                    if (neighborNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < neighborNode.minCostToStart)
                    {
                        // if it is then set this node as being nearest to start
                        neighborNode.minCostToStart = node.minCostToStart + cnn.cost;
                        neighborNode.nearestToStart = node;

                        // and add this neighbor to the queue
                        if (!queue.Contains(neighborNode))
                        {
                            queue.Add(neighborNode);
                        }
                    }
                }

                // set this node as being visited
                node.visited = true;

                // if we reached the target, then we're done!
                if (node == graph[(int)EColors.Green])
                {
                    return;
                }

            } while (queue.Any());
        }

    }
}
