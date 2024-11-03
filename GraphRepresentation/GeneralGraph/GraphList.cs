namespace Graph;

public abstract class GraphList  : IGraph
{
    protected  readonly  List<List<int>> _graph;
  
    public List<List<int>> Graph => _graph;
    protected GraphList(int NodesNumber)
    {
        _graph = new List<List<int>>(NodesNumber);

        foreach (var N in Enumerable.Range(0, NodesNumber))
        {
            _graph.Add(new List<int>());
        }
    }
    
    public    abstract void AddEdge(int from, int to);

    public bool IsVaild(int from, int to)
        => !(from >= _graph.Count || to >= _graph.Count || from < 0 || to < 0);

}