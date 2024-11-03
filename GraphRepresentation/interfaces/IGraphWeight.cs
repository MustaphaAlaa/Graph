namespace Graph;

public interface IGraphWeight <T>
{
    
    public void AddEdge(int from, int to, T weight); 

}