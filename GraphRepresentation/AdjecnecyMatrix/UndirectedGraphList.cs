namespace Graph;

public class UndirectedGraphMatrix :  GraphList, IGraph
{
    public UndirectedGraphMatrix(int NodesNumber) : base(NodesNumber)
    {
    }

    public override void AddEdge(int from, int to)
    {
        if(!IsVaild(from , to ))
            return;
        _graph[from].Add(to);
        _graph[to].Add(from);
    }
}