using System;

class Program
{
    static void Main()
    {
        
        string word = "собака";

        
        char[] guessedWord = new string('_', word.Length).ToCharArray();

        
        int maxWrongAttempts = 6;
        int wrongAttempts = 0;

       
        Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
        Console.WriteLine($"Кількість літер у слові: {word.Length}");
        Console.WriteLine($"Кількість можливих невірних спроб: {maxWrongAttempts}");

        
        while (wrongAttempts < maxWrongAttempts)
        {
            
            Console.WriteLine($"Поточне слово: {new string(guessedWord)}");

            
            Console.Write("Введіть вашу літеру: ");
            char guessedLetter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            
            if (word.Contains(guessedLetter))
            {
                Console.WriteLine($"Така літера є у слові! Позиція літери:");

                
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == guessedLetter)
                    {
                        guessedWord[i] = guessedLetter;
                        Console.WriteLine($"Позиція літери: {i + 1}");
                    }
                }
            }
            else
            {
                
                wrongAttempts++;
                Console.WriteLine($"Такої літери немає! Залишилось спроб: {maxWrongAttempts - wrongAttempts}");
            }

            
            if (new string(guessedWord) == word)
            {
                Console.WriteLine($"Вітаємо, ви вгадали слово! Зашифроване слово: {word}.");
                
                break;
            }

            
            if (wrongAttempts == maxWrongAttempts)
            {      
                Console.WriteLine("Вибачте, ви програли.");
                Console.WriteLine($"Зашифроване слово було: {word}");
               
            }
        }
    }
}
