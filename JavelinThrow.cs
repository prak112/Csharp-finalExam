using CourseExam;

namespace CourseExam
{
    public class JavelinThrow
    {
        // Property
        public string Name { get; set; }
        public double ThrowDistance_inMeters { get; set; }
        public double ThrowDistance_inCentimeters { get; set; }
        //List<Athelete> AtheleteRecords { get; set; }

        // Constructor
        public JavelinThrow(string aName, double aThrowDistance_inMeters, double aThrowDistance_inCentimeters)
        {
            Name = aName;
            ThrowDistance_inMeters = aThrowDistance_inMeters;
            ThrowDistance_inCentimeters = aThrowDistance_inCentimeters;
        }

    }
}