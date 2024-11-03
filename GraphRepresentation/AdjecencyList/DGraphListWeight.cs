using System.Runtime.CompilerServices;
using Graph;

namespace Graph;

public class DGraphListWeight<T> :   WeightGraphList<T>
{
    
    
    protected List<List<(int,T) >> _graph;
    public DGraphListWeight(int NodesNumber) : base(NodesNumber)
    {
    }

    public override void AddEdge(int from, int to  )
    {
        this._graph[from].Add((to,default(T)));
    }
    

    public  override void AddEdge(int from, int to, T weight   )
    {
        this._graph[from].Add((to,weight));
    }
    
    
    
}