using System;

public class FilaDePrioridade<T> : IFilaDePrioridade<T> where T : IComparable<T>
{
    private T[] heap;
    private int tamanho;

    public FilaDePrioridade(int capacidade = 100)
    {
        heap = new T[capacidade + 1];
        tamanho = 0;
    }

    public bool IsEmpty()
    {
        return tamanho == 0;
    }

    public int Size()
    {
        return tamanho;
    }

    public void Insert(T dado)
    {
        if (tamanho >= heap.Length - 1)
            throw new InvalidOperationException("Fila cheia");

        tamanho++;
        heap[tamanho] = dado;
        UpHeap();
    }

    public T Min()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Fila vazia");

        return heap[1];
    }

    public T RemoveMin()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Fila vazia");

        T min = heap[1];
        heap[1] = heap[tamanho];
        tamanho--;

        DownHeap();

        return min;
    }

    private void UpHeap()
    {
        int filho = tamanho;

        while (filho > 1)
        {
            int pai = filho / 2;
            if (heap[filho].CompareTo(heap[pai]) < 0)
            {
                (heap[filho], heap[pai]) = (heap[pai], heap[filho]);
                filho = pai;
            }
            else
            {
                break;
            }
        }
    }

    private void DownHeap()
    {
        int pai = 1;

        while (pai * 2 <= tamanho)
        {
            int filhoEsq = pai * 2;
            int filhoDir = filhoEsq + 1;
            int menorFilho = filhoEsq;

            if (filhoDir <= tamanho && heap[filhoDir].CompareTo(heap[filhoEsq]) < 0)
            {
                menorFilho = filhoDir;
            }

            if (heap[menorFilho].CompareTo(heap[pai]) < 0)
            {
                (heap[pai], heap[menorFilho]) = (heap[menorFilho], heap[pai]);
                pai = menorFilho;
            }
            else
            {
                break;
            }
        }
    }
}
