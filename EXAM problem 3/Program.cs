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

             //List<Node> shortestPathFromTHTtoHTH = GetShortestPathDijkstra();

            while (true)
            {
                nState = rand.Next(0, Enum.GetNames(typeof(EColors)).Length);

                if (nState != (int)EColors.Green)
                {
                    break;
                }
            }

            Thread t = new Thread(DFS);
            t.Start();




        }

        //FOR QUESTION 5
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





    }
}
