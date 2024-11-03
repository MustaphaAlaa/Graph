namespace Graph;

public class PrintGraphList //: IPrintGraph
{
    public  static void Print(GraphList graphList)
    {
        if (graphList.Graph == null)
            return;

        for (int from = 0; from < graphList.Graph.Count; from++)
        {
            if (graphList.Graph[from].Count > 0)
                /*System.Console.WriteLine($"Node {from} has neighbors: ");*/
                Console.WriteLine($"Neighbors Of Node {from} Is: ");
            else
                continue;

            for (int to = 0; to < graphList.Graph[from].Count; to++)
                System.Console.Write($"{graphList.Graph[from][to]}, ");
            Console.WriteLine();
        }
    }
}