namespace Graph;

public class AdjMatrixGraph
{

    List<List<int>> graph;

    public AdjMatrixGraph(List<List<int>> graph)
    {
        this.graph = graph;
    }

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
                
                GraphWithCost(undirected, cost,  from, to);
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

    private void GraphWithCost(bool undirect, int cost, int from, int to)
    {
        if (undirect)
        {
            CostFromTo(from, to, cost);
            CostFromTo(to, from, cost);
        }
        else CostFromTo(from, to, cost);

    }


    private void FromTo(int from, int to)
    {
        graph[from][to] += 1;
    }
    private void CostFromTo(int from, int to, int cost)
    {
        graph[from][to] = cost;
    }
    public void Print()
    {
        for (int from = 0; from < graph.Count; from++)
            for (int to = 0; to < graph[from].Count; to++)
                if (graph[from][to] > 0)
                    System.Console.WriteLine($"From {from} To {to} has {graph[from][to]} edges");
    }

}


