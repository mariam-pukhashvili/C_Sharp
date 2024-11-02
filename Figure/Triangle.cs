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
    public override bool Isosceles()
    {

        // SegmentOne = segmentOne;
        // SegmentTwo = segmentTwo;
        // SegmentThree = segmentThree;
        if (SegmentOne == SegmentTwo) return true;
        else if (SegmentTwo == SegmentThree) return true;
        else if (SegmentThree == SegmentOne) return true;
        else return false;

    }

}