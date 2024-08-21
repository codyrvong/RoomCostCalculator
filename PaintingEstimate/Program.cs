using System;
using static System.Console;
class PaintingEstimate
{
    static void Main()
    {
        int roomLength;
        int roomWidth;
        double paintCost;

        Write("Enter length of the room in feet >> ");
        roomLength = Convert.ToInt32(ReadLine());

        Write("Enter width of room in feet >> ");
        roomWidth = Convert.ToInt32(ReadLine());

        paintCost = CostCalculation(roomLength, roomWidth);
        WriteLine("Cost of painting the room is {0:C2}", paintCost);
    }
    private static double CostCalculation(int roomLength, int roomWidth)
    {
        int roomHeight = 15;
        int jobPrice = 12;
        double paintArea = (roomLength * roomHeight * 2) + (roomWidth * roomHeight * 2);
        double paintRoomCost = jobPrice * paintArea;
        return paintRoomCost;
    }
}