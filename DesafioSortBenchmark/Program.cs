using System.Diagnostics;
using System.Text.Json;

string arquivoJson = "input.json";
await ProcessarEOrdenarStringsAsync(arquivoJson);
async Task ProcessarEOrdenarStringsAsync(string arquivoJson)
{
    using FileStream stream = File.OpenRead(arquivoJson);

    List<string>? listaStrings = await JsonSerializer.DeserializeAsync<List<string>>(stream);

    if (listaStrings is null || listaStrings.Count == 0)
    {
        Console.WriteLine("Lista vazia.");
        return;
    }

    List<string> listaInsertion = new(listaStrings);
    Stopwatch sw = Stopwatch.StartNew();
    InsertionSort(listaInsertion);
    sw.Stop();
    Console.WriteLine($"Insertion Sort: {sw.ElapsedMilliseconds} ms");

    List<string> listaBubble = new(listaStrings);
    sw.Restart();
    BubbleSort(listaBubble);
    sw.Stop();
    Console.WriteLine($"Bubble Sort: {sw.ElapsedMilliseconds} ms");

    List<string> listaQuick = new(listaStrings);
    sw.Restart();
    QuickSort(listaQuick, 0, listaQuick.Count - 1);
    sw.Stop();
    Console.WriteLine($"Quick Sort: {sw.ElapsedMilliseconds} ms");
}
void InsertionSort(List<string> listaStrings)
{
    for (int i = 1; i < listaStrings.Count; i++)
    {
        string chave = listaStrings[i];
        int j = i - 1;

        while (j >= 0 && string.Compare(listaStrings[j], chave, StringComparison.OrdinalIgnoreCase) > 0)
        {
            listaStrings[j + 1] = listaStrings[j];
            j--;
        }
        listaStrings[j + 1] = chave;
    }
}
void BubbleSort(List<string> listaStrings)
{
    for (int i = 0; i < listaStrings.Count; i++)
    {
        bool houveTroca = false;
        for (int j = 0; j < listaStrings.Count - 1 - i; j++)
        {
            if (string.Compare(listaStrings[j], listaStrings[j + 1], StringComparison.OrdinalIgnoreCase) > 0)
            {
                string temp = listaStrings[j];
                listaStrings[j] = listaStrings[j + 1];
                listaStrings[j + 1] = temp;
                houveTroca = true;
            }
        }
        if (houveTroca == false) break;
    }
}
void QuickSort(List<string> listaStrings, int inicio, int fim)
{
    if (inicio < fim)
    {
        int pivoIndex = Particionar(listaStrings, inicio, fim);

        QuickSort(listaStrings, inicio, pivoIndex - 1);
        QuickSort(listaStrings, pivoIndex + 1, fim);
    }
}

int Particionar(List<string> listaStrings, int inicio, int fim)
{
    string pivo = listaStrings[fim];
    int i = inicio - 1;

    for (int j = inicio; j < fim; j++)
    {
        if (string.Compare(listaStrings[j], pivo, StringComparison.OrdinalIgnoreCase) < 0)
        {
            i++;
            (listaStrings[i], listaStrings[j]) = (listaStrings[j], listaStrings[i]);
        }
    }
    (listaStrings[i + 1], listaStrings[fim]) = (listaStrings[fim], listaStrings[i + 1]);
    return i + 1;
}
