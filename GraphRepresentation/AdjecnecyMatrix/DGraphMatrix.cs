using System.Runtime.CompilerServices;

namespace Graph;

public class DGraphMatrix  :GraphMatrix 
{ 
    public DGraphMatrix(int NodesNumber) : base(NodesNumber) {}
    public override  void AddEdge(int from, int to)
    {
        if(!IsVaild(from , to ))
            return;
        /*_graph[from].Add(to); */
    }
}