using System;

class Program
{
    static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };  
    static int currentPlayer = 1; 
    static int choice;  
    static int flag = 0;  
    
    static void Main(string[] args)
    {
        do
        {
            Console.Clear();  
            DrawBoard(); 

            
            currentPlayer = (currentPlayer % 2) + 1;

            
            Console.WriteLine($"Гравець {currentPlayer} ({(currentPlayer == 1 ? 'X' : 'O')}) - Виберіть клітинку (1-9): ");
            choice = int.Parse(Console.ReadLine());

           
            if (board[choice] != 'X' && board[choice] != 'O')
            {
                board[choice] = (currentPlayer == 1) ? 'X' : 'O';  
            }
            else
            {
                Console.WriteLine("Ця клітинка вже зайнята! Спробуйте ще раз.");
                currentPlayer--;
                Console.ReadKey();
            }
            flag = CheckWin();  

        } while (flag != 1 && flag != -1);  

        
        Console.Clear();
        DrawBoard();
        if (flag == 1)
            Console.WriteLine($"Гравець {currentPlayer} виграв!");
        else
            Console.WriteLine("Нічия!");
        Console.ReadLine();
    }

  
    static void DrawBoard()
    {
        Console.WriteLine("Гра Хрестики-Нолики!");
        Console.WriteLine("-------------");
        Console.WriteLine($"| {board[1]} | {board[2]} | {board[3]} |");
        Console.WriteLine("-------------");
        Console.WriteLine($"| {board[4]} | {board[5]} | {board[6]} |");
        Console.WriteLine("-------------");
        Console.WriteLine($"| {board[7]} | {board[8]} | {board[9]} |");
        Console.WriteLine("-------------");
    }

    
    static int CheckWin()
    {
        
        
        if (board[1] == board[2] && board[2] == board[3]) return 1;
        else if (board[4] == board[5] && board[5] == board[6]) return 1;
        else if (board[7] == board[8] && board[8] == board[9]) return 1;

       
        else if (board[1] == board[4] && board[4] == board[7]) return 1;
        else if (board[2] == board[5] && board[5] == board[8]) return 1;
        else if (board[3] == board[6] && board[6] == board[9]) return 1;

       
        else if (board[1] == board[5] && board[5] == board[9]) return 1;
        else if (board[3] == board[5] && board[5] == board[7]) return 1;

       
        else if (board[1] != '1' && board[2] != '2' && board[3] != '3' &&
            board[4] != '4' && board[5] != '5' && board[6] != '6' &&
            board[7] != '7' && board[8] != '8' && board[9] != '9')
            return -1;
        else
            return 0;
       
    }
}
