namespace StringArrays10B24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Write a subroutine called Prefix from your pseudo-code 
             * The subroutine takes two, character arrays called word and pre as parameters and 
             * The subroutine determines whether the start of the character array word is the 
             * same as all of the character array pre.*/

            /* Your subroutine should also:
	•           work for character arrays of all lengths greater than 0
	•           not assume that the length of pre is less than the length of word.*/

            /* use fixed (hard coded) string arrays to test your code. 
             Call your subroutine using your test arrays from Main() routine
             and return the result to Main() */

            /* Starter code for your subroutine has been provided*/
            string[] a = {"a", "b",  "c", "d", "e"};
            string[] b = { "a", "b", "c" };
            Console.WriteLine(Prefix(a, b));
        }
        static bool Prefix(string[] word, string[] pre) 
        {
            int i = 0;

            if (pre.Length > word.Length) 
            {
                return false;
            }
            else
            {
                i = 1;
            }

            while(i  < pre.Length) 
            {
                if (word[i] != pre[i])
                {
                    return false;
                }
                i = i + 1;
            }
            return true;
        }
    }
}
