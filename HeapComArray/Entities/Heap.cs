public class Heap<T> where T : IComparable<T>
{
    public int Tamanho { get; private set; }
    public T[] ArrayHeap { get; set; }

    public Heap()
    {
        Tamanho = 0;
        ArrayHeap = new T[100]; // Inicia com capacidade para 100 elementos
    }

    // Métodos auxiliares
    public bool IsEmpty()
    {
        return Tamanho == 0;
    }

    public bool IsFull()
    {
        return Tamanho == ArrayHeap.Length - 1;
    }

    // Inserir novo elemento
    public void Insert(T dado)
    {
        if (!IsFull())
        {
            Tamanho++;
            ArrayHeap[Tamanho] = dado;
            UpHeap();
        }
    }

    // Remove a raiz (elemento do topo)
    public T? Remove()
    {
        if (IsEmpty())
            return default;

        T raiz = ArrayHeap[1];
        ArrayHeap[1] = ArrayHeap[Tamanho];
        Tamanho--;

        DownHeap();

        return raiz;
    }

    // Sobe o elemento inserido até sua posição correta
    public void UpHeap()
    {

    }

    // Desce a raiz trocada até sua posição correta
    public void DownHeap()
    {

    }
}
