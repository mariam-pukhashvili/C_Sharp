Console.WriteLine(ForMath.Add(23, 4));


Rectangle[] rectangles = new Rectangle[3];

rectangles[0] = new Rectangle(2, 3);
rectangles[1] = new Rectangle(4, 5);
rectangles[2] = new Rectangle(5, 8);

for (int i = 0; i < rectangles.Length; i++)
{
    Console.WriteLine($"Rectanle {i + 1}  Perimeter={rectangles[i].Perimeter()}");
}



