using System;

class ChessKnight
{
    static void Main()
    {
        Console.WriteLine("Введите позицию белого коня (например, b1):");
        string whiteKnightPosition = Console.ReadLine();

        Console.WriteLine("Введите позицию черного коня (например, c3):");
        string blackKnightPosition = Console.ReadLine();

        if (IsValidPosition(whiteKnightPosition) && IsValidPosition(blackKnightPosition))
        {
            DecodePosition(whiteKnightPosition, out int whiteKnightX, out int whiteKnightY);
            DecodePosition(blackKnightPosition, out int blackKnightX, out int blackKnightY);

            if (whiteKnightPosition == blackKnightPosition)
            {
                Console.WriteLine("Позиции фигур совпадают.");
            }
            else if (IsKnightMovePossible(whiteKnightX, whiteKnightY, blackKnightX, blackKnightY))
            {
                Console.WriteLine("Белый конь находится под ударом черного коня.");
            }
            else if (IsKnightMovePossible(blackKnightX, blackKnightY, whiteKnightX, whiteKnightY))
            {
                Console.WriteLine("Черный конь находится под ударом белого коня.");
            }
            else
            {
                Console.WriteLine("Фигуры не находятся под ударом друг друга.");
            }
        }
        else
        {
            Console.WriteLine("Некорректные позиции. Проверьте, что позиции находятся в пределах доски.");
        }
    }

    static bool IsValidPosition(string position)
    {
        if (position.Length == 2 &&
        position[0] >= 'a' && position[0] <= 'h' &&
        position[1] >= '1' && position[1] <= '8')
        {
            return true;
        }
        return false;
    }

    static void DecodePosition(string position, out int x, out int y)
    {
        x = position[0] - 'a' + 1;
        y = position[1] - '1' + 1;
    }

    static bool IsKnightMovePossible(int startX, int startY, int targetX, int targetY)
    {
        int dx = Math.Abs(startX - targetX);
        int dy = Math.Abs(startY - targetY);
        return (dx == 2 && dy == 1) || (dx == 1 && dy == 2);
    }
}