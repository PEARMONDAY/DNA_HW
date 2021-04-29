using System;

namespace DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = false;
            while (check != true)
            {
                char TorF;
                Console.Write("Input DNA =");
                string halfDNASequence = Console.ReadLine();
                bool checkhalfDNASequence = IsvalidSequence(halfDNASequence);
                bool check_halfDNASequence = false;
                if (checkhalfDNASequence == true)
                {
                    Console.WriteLine("DNAsequence =" + halfDNASequence);
                    while (check == false)
                    {
                        Console.Write("Do you want to .... ? (Y/N) =");
                        TorF = char.Parse(Console.ReadLine());
                        if (TorF == 'Y')
                        {
                            string Y = ReplicateSeqeunce(halfDNASequence);
                            Console.WriteLine("DNAsequence =" + Y);
                            check_halfDNASequence = true;
                        }
                        else if (TorF == 'F')
                        {
                            check_halfDNASequence = true;
                        }
                        else
                            Console.Write("Pls Input Y or N");
                    }
                }
                else if (check_halfDNASequence == false)
                {
                    Console.WriteLine("DNA is Invalid");
                    while (check_halfDNASequence != true)
                    {
                        Console.Write("Do you want to process another ? (Y/N) =");
                        TorF = char.Parse(Console.ReadLine());
                        if (TorF == 'Y')
                        {
                            check_halfDNASequence = true;
                        }
                        else if (TorF == 'N')
                        {
                            check_halfDNASequence = true;
                            check = true;
                        }
                        else
                            Console.Write("Pls Input Y or N");
                    }
                }
                else
                    Console.Write("ERROR");
            }
        }
        static bool IsvalidSequence(string halfDNASequence)
        {
            foreach(char nucletide in halfDNASequence)
            {
                if (!"ATCG".Contains(nucletide))
                {
                    return false;
                }
            }
            return false;
        }
        static string ReplicateSeqeunce(string halfDNASequence)
        {
            string result = "";
            foreach(char nucletide in halfDNASequence)
            {
                result += "TAGC"["ATCG".IndexOf(nucletide)];
            }
            return result;
        }
    }
}
