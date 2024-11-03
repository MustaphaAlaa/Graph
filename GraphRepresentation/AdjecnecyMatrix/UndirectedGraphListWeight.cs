using Graph;

namespace Graph;

public class UndirectedGraphMatrixWeight<T> : WeightGraphList<T> 
{
    
    
    protected List<List<(int,T) >> _graph;
    public UndirectedGraphMatrixWeight(int NodesNumber) : base(NodesNumber)
    {
        
    }

    public override void AddEdge(int from, int to  )
    {
        this._graph[from].Add((to,default(T)));
        this._graph[to].Add((from,default(T)));
    }
    

    public override  void AddEdge(int from, int to, T weight   )
    {
        this._graph[from].Add((to,weight));
        this._graph[to].Add((from,weight));
    }
    
    
    
}