// В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

Console.WriteLine("Введите число N:");
int num = int.Parse(Console.ReadLine());

String symbols = "аисв";

int n = 1;

void FindWords(string alfavit, char[] word, int length = 0)
{
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new string(word)}"); 
        return;
    }

    for (int i = 0; i < alfavit.Length; i++)
    {
        word[length] = alfavit[i];
        FindWords(alfavit, word, length + 1);
    }
}

FindWords(symbols, new char[num]);