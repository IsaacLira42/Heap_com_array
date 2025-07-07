public interface IHeap<T> where T : IComparable<T>
{
    // Métodos Auxiliares
    bool IsEmpty();
    bool IsFull();

    // Métodos Principais do Heap
    void Insert(T dado);
    T? Remove();  // Retorna T ou null (se vazio)
    void UpHeap();
}
