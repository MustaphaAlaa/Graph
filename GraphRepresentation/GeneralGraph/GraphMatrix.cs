namespace Graph;

public abstract class GraphMatrix  : IGraph
{
    protected  readonly  int[,] _graph;
  
    public int[,] Graph => _graph;
    protected GraphMatrix(int NodesNumber)
    {
        _graph = new int[NodesNumber, NodesNumber];
        
    }
    
    public    abstract void AddEdge(int from, int to);

    public bool IsVaild(int from, int to)
        => !(from >= _graph.GetLength(0) || to >= _graph.GetLength(1) || from < 0 || to < 0);

}