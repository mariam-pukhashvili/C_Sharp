public class Triangle : Figure
{
    public Segment SegmentOne { get; }
    public Segment SegmentTwo { get; }

    public Segment SegmentThree { get; }
    public Angle AngleOne { get; }
    public Angle AngleTwo { get; }
    public Angle AngleThree { get; }

    //
    public Triangle(Segment segmentOne, Segment segmentTwo, Segment segmentThree, Angle angleOne, Angle angleTwo, Angle angleThree)
    {

        SegmentOne = segmentOne;
        SegmentTwo = segmentTwo;
        SegmentThree = segmentThree;
        AngleOne = angleOne;
        AngleTwo = angleTwo;
        AngleThree = angleThree;
    }
    //Segment segmentOne, Segment segmentTwo, Segment segmentThree
    public override bool IsTriangle()
    {
        if ((AngleOne.AngleSize + AngleTwo.AngleSize + AngleThree.AngleSize) == 180) return true;
        else return false;
    }

    public override bool IsIsosceles()
    {
        if (SegmentOne.Length == SegmentTwo.Length) return true;
        else if (SegmentTwo.Length == SegmentThree.Length) return true;
        else if (SegmentThree.Length == SegmentOne.Length) return true;
        else return false;
    }
    public override bool IsEquilateral()
    {
        if (SegmentOne.Length == SegmentTwo.Length && SegmentTwo.Length == SegmentThree.Length) return true;
        else return false;
    }
    public override bool IsRight()
    {
        if (AngleOne.AngleSize == 90 || AngleTwo.AngleSize == 90 || AngleThree.AngleSize == 90) return true;
        else return false;
    }


}