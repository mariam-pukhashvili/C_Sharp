// See https://aka.ms/new-console-template for more information




Segment segment1 = new Segment(5.0);
Segment segment2 = new Segment(10.0);
Segment segment3 = new Segment(30.0);


Console.WriteLine(segment1.Length);


Angle angle1 = new Angle(segment1, segment2, 100);
Angle angle2 = new Angle(segment1, segment2, 40);
Angle angle3 = new Angle(segment1, segment2, 40);


//Console.WriteLine(angle1.AngleSize);

////is or not triangle Isosceles

Triangle triangle = new Triangle(segment1, segment2, segment3, angle1, angle2, angle3);


Console.WriteLine(triangle.Isosceles());




