using Graph;
namespace Graph;

class Program
{
    static void Main(string[] args) 
    {
        UndirectedGraphList graphList = new(7);
        
        graphList.AddEdge(1,3);
        graphList.AddEdge(1,3);
        graphList.AddEdge(1,6);
        graphList.AddEdge(6,2);
        
        PrintGraphList.Print(graphList);

        Console.WriteLine("\n\n-------------------------------------------------\n\n");
        
        DGraphList DgraphList = new(7);
        
        DgraphList.AddEdge(1,3);
        DgraphList.AddEdge(1,3);
        DgraphList.AddEdge(1,6);
        DgraphList.AddEdge(6,2);
        
        PrintGraphList.Print(DgraphList);    
        
    
    }
}