public interface IFilaDePrioridade<T> where T : IComparable<T>
{
    void Insert(T item);
    T RemoveMin();
    T Min();
    bool IsEmpty();
    int Size();
}