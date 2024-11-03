namespace Graph;

public class Graph
{  
    private readonly IGraph _graph;
     
    public Graph(IGraph graph)
    {
        _graph = graph;
    }


    public void AddEdge(int from, int to, int? weight = null)
    {
        if (weight.HasValue)
            ;
        /*_graph.AddEdge(from,to,weight.Value); */
        else
            _graph.AddEdge(from,to );
    }
    
    
  
}