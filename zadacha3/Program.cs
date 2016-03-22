using System;
class MatrixOfPalindromes
{
    static void Main()
    {
        Console.Write("enter rows = ");
        int row = int.Parse(Console.ReadLine());
        Console.Write("enter column = ");
        int column = int.Parse(Console.ReadLine());
        char changeLetter = 'a';

        for (int i = 0; i < row; i++)
        {

            for (int j = 0; j < column; j++)
            {
                char newLetter = Convert.ToChar(changeLetter + j);

                Console.Write("{0}{1}{0} ", changeLetter, newLetter);

            }
            Console.WriteLine();
            changeLetter++;
        }

    }
}
