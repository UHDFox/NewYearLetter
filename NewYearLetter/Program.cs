using System;


namespace NewYearLetter
{

    class Letter
    {
        int lengthOfLetter;
        string text;
        string theme;
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to write a letter to Santa or to Capybara(1 - Santa, 2 - Capy)");
            string question = Console.ReadLine();
            int intQuestion = Int32.Parse(question);
            if (intQuestion == 1)
            {
                Letter NewYearLetter = new Letter();
                Console.WriteLine("Write a theme of your letter");
                NewYearLetter.theme = Console.ReadLine();
                Console.WriteLine("Here comes a letter itself: ");
                NewYearLetter.text = Console.ReadLine();
                NewYearLetter.lengthOfLetter = (NewYearLetter.text).Length;
                Console.WriteLine("Will you sign the letter?(1 - yes; 2 - no)");
                int isSigned = Int32.Parse(Console.ReadLine());
                if (isSigned == 1)
                {
                    Console.WriteLine("Sign your letter!");

                    string sign = Console.ReadLine();
                    Console.WriteLine($"What a great letter we've got here! I think Santa will be happy to read it! \n There're some stats: \n Theme: {NewYearLetter.theme} \n How many symbols are there? - {NewYearLetter.lengthOfLetter} \n Written by: {sign}");

                }
                else
                {
                    Console.WriteLine($"Lovely! I like your letter and I'm sure Mr.Capy'll love it too! \n ------There're some stats: ------\n Theme: {NewYearLetter.theme} \n How many symbols are there? - {NewYearLetter.lengthOfLetter}");
                }
                
            }
            else
            {
                Letter CapybaraLetter = new Letter();
                Console.WriteLine("Write a theme of your letter");
                CapybaraLetter.theme = Console.ReadLine();
                Console.WriteLine("Here comes a letter itself: ");
                CapybaraLetter.text = Console.ReadLine();
                CapybaraLetter.lengthOfLetter = (CapybaraLetter.text).Length;
                Console.WriteLine("Will you sign the letter?(1 - yes; 2 - no)");
                int isSigned = Int32.Parse(Console.ReadLine());
                if(isSigned == 1)
                {
                    Console.WriteLine("Sign your letter!");

                    string sign = Console.ReadLine();
                    Console.WriteLine($"Lovely! I like your letter and I'm sure Mr.Capy'll love it too! \n ------There're some stats: ------\n Theme: {CapybaraLetter.theme} \n How many symbols are there? - {CapybaraLetter.lengthOfLetter} \n Written by: {sign}");

                }
                else
                {
                    Console.WriteLine($"Lovely! I like your letter and I'm sure Mr.Capy'll love it too! \n There're some stats: \n Theme: {CapybaraLetter.theme} \n How many symbols are there? - {CapybaraLetter.lengthOfLetter}");
                }
            }

        }
    }
}