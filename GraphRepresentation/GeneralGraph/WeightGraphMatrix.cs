namespace Graph;

public abstract class WeightGraphMatrix<T>  : IGraphWeight<T>
{
    protected  readonly  List<List<int>> _graph;
  
    public List<List<int>> Graph => _graph;
    protected WeightGraphMatrix(int NodesNumber)
    {
        _graph = new (NodesNumber);

        foreach (var N in Enumerable.Range(0, NodesNumber))
        {
            _graph.Add(new());
        }
    }
    
    public    abstract void AddEdge(int from, int to);
    public    abstract void AddEdge(int from, int to,T weight);

    public bool IsVaild(int from, int to)
        => !(from >= _graph.Count || to >= _graph.Count || from < 0 || to < 0);

}