using System;

class Program
{
    static void Main(string[] args)
    {
        IFilaDePrioridade<int> fila = new FilaDePrioridade<int>();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\n====== MENU - Fila de Prioridade (Min-Heap) ======");
            Console.WriteLine("1 - Inserir elemento");
            Console.WriteLine("2 - Remover menor elemento (RemoveMin)");
            Console.WriteLine("3 - Ver menor elemento (Min)");
            Console.WriteLine("4 - Ver tamanho da fila (Size)");
            Console.WriteLine("5 - Verificar se está vazia (IsEmpty)");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string? opcao = Console.ReadLine();
            Console.WriteLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite um número inteiro para inserir: ");
                    if (int.TryParse(Console.ReadLine(), out int valor))
                    {
                        fila.Insert(valor);
                        Console.WriteLine($"{valor} inserido na fila.");
                    }
                    else
                    {
                        Console.WriteLine("Entrada inválida.");
                    }
                    break;

                case "2":
                    if (!fila.IsEmpty())
                    {
                        int removido = fila.RemoveMin();
                        Console.WriteLine($"Elemento removido: {removido}");
                    }
                    else
                    {
                        Console.WriteLine("Fila vazia. Nada para remover.");
                    }
                    break;

                case "3":
                    if (!fila.IsEmpty())
                    {
                        Console.WriteLine($"Menor elemento: {fila.Min()}");
                    }
                    else
                    {
                        Console.WriteLine("Fila vazia.");
                    }
                    break;

                case "4":
                    Console.WriteLine($"Tamanho atual da fila: {fila.Size()}");
                    break;

                case "5":
                    Console.WriteLine($"Fila vazia? {fila.IsEmpty()}");
                    break;

                case "0":
                    continuar = false;
                    Console.WriteLine("Encerrando o programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }
    }
}
