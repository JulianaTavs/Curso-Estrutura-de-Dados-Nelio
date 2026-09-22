Solution solution = new Solution();
solution.ReverseList(["Azul", "Amarelo", "Cinza", "Preto"]);
solution.ReverseList(["Azul", "Amarelo", "Cinza", "Laranja", "Preto"]);
solution.ReverseList([]);
solution.ReverseList(["Azul"]);

public class Solution
{
    public List<string> ReverseList(List<string> strings)
    {
        // Jeito 1:
        //strings.Reverse();
        //Console.WriteLine(string.Join(",", strings)); //Só pra ver como ficou a ordem.
        //return strings;

        // Jeito 2:
        if (strings.Count <= 1)
        {
            Console.WriteLine(string.Join(",", strings));
            return strings;
        }
        if (strings.Count % 2 == 0)
        {
            for (int i = 0; i < (strings.Count / 2); i++)
            {
                int j = strings.Count - 1 - i;
                {
                    string temp = strings[i];
                    strings[i] = strings[j];
                    strings[j] = temp;
                }
            }
            Console.WriteLine(string.Join(",", strings));
            return strings;
        }
        else
        {
            for (int i = 0; i < (strings.Count - 1) / 2; i++)
            {
                int j = strings.Count - 1 - i;
                {
                    string temp = strings[i];
                    strings[i] = strings[j];
                    strings[j] = temp;
                }
            }
            Console.WriteLine(string.Join(",", strings));
            return strings;
        }

        // Jeito 3:

        //List<string> reversed = new List<string>();

        //int i = strings.Count - 1;
        //while (i >= 0)
        //{
        //    reversed.Add(strings[i]);
        //    i--;
        //}
        //Console.WriteLine(string.Join(",", reversed));
        //return reversed;



    }
}