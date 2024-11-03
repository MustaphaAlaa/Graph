using System.Runtime.CompilerServices;

namespace Graph;

public class DGraphList :GraphList 
{ 
    public DGraphList(int NodesNumber) : base(NodesNumber) {}
    public override  void AddEdge(int from, int to)
    {
        if(!IsVaild(from , to ))
            return;
        _graph[from].Add(to);
    }
}