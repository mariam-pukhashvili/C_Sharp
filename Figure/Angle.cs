public class Angle
{
    public Segment SegmentOne { get; set; }
    public Segment SegmentTwo { get; set; }
    public double AngleSize { get; set; }



    public Angle(Segment segmentOne, Segment segmentTwo, double angleSize)
    {
        SegmentOne = segmentOne;
        SegmentTwo = segmentTwo;
        AngleSize = angleSize;
    }


}