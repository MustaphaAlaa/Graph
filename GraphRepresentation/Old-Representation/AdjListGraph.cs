using System.Runtime.InteropServices;
namespace Graph;

public class AdjListGraph
{

    private readonly List<List<stEdge>> _graphWithCost;
    private readonly List<List<int>> _graph;

    public AdjListGraph(List<List<stEdge>> graph)
         => _graphWithCost = graph;
    public AdjListGraph(List<List<int>> graph)
         => _graph = graph;



    public void SetGraph(int edges, bool undirected, bool HasCost)
    {
        for (int i = 0; i < edges; i++)
        {
            System.Console.WriteLine("From:");
            int.TryParse(Console.ReadLine(), out int from);

            System.Console.WriteLine("To:");
            int.TryParse(Console.ReadLine(), out int to);


            if (HasCost)
            {
             
                System.Console.WriteLine("Cost:");
                int.TryParse(Console.ReadLine(), out int cost);

                GraphWithCost(undirected, from, new stEdge { To = to, Weight = cost });
            }
            else if (undirected)
            {
                this.FromTo(from, to);
                this.FromTo(to, from);
            }

            else
            {
                this.FromTo(from, to);
            }
        }
    }

    

    public void SetGraph(int edges, bool undirected )
    {
        for (int i = 0; i < edges; i++)
        {
            System.Console.WriteLine("From:");
            int.TryParse(Console.ReadLine(), out int from);

            System.Console.WriteLine("To:");
            int.TryParse(Console.ReadLine(), out int to);


            if (_graph is List<List<stEdge>> )
            {

                System.Console.WriteLine("Cost:");
                int.TryParse(Console.ReadLine(), out int cost);

                GraphWithCost(undirected, from, new stEdge { To = to, Weight = cost });
            }
            else if (undirected)
            {
                this.FromTo(from, to);
                this.FromTo(to, from);
            }

            else
            {
                this.FromTo(from, to);
            }
        }
    }

    
    
    private void GraphWithCost(bool undirect, int from, stEdge edge)
    {
        if (undirect)
        {
            CostFromTo(from, edge.To, edge.Weight);
            CostFromTo(edge.To, from, edge.Weight);
        }
        else CostFromTo(from, edge.To, edge.Weight);

    }


    private void FromTo(int from, int to)
    {
        _graph[from].Add(to);
    }
    
    private void CostFromTo(int from, int to, int? cost)
    {
        _graphWithCost[from].Add(new stEdge { To = to, Weight = cost });
    }
    public void Print()
    {
        if (_graph == null)
            return;

        for (int from = 0; from < _graph.Count; from++)
        {
            if (_graph[from].Count > 0)
                System.Console.WriteLine($"Node {from} has neighbors: ");
            else
                break;

            for (int to = 0; to < _graph[from].Count; to++)
                System.Console.Write($"{_graph[from][to]}, ");
        }
    }
    public void PrintWithCost()
    {
        for (int from = 0; from < _graphWithCost.Count; from++)
        {
            if (_graphWithCost[from].Count > 0)
                System.Console.WriteLine($"Node {from} has neighbors: ");
            else
                continue;

            for (int to = 0; to < _graphWithCost[from].Count; to++)
                System.Console.Write($"(To {_graphWithCost[from][to].To}, Cost {_graphWithCost[from][to].Weight}), ");
            System.Console.WriteLine();
        }
    }

}


