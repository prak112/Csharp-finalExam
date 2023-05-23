using CourseExam;

namespace CourseExam
{
    //public class Athelete
    //{
    //    // Property
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int ThrowDistance_inMeters { get; set; }
    //    public int ThrowDistance_inCentimeters { get; set; }
    //}

    // Constructor
    public class JavelinThrow
    {
        // Property
        public int Id { get; set; }
        public string Name { get; set; }
        public int ThrowDistance_inMeters { get; set; }
        public int ThrowDistance_inCentimeters { get; set; }
        //List<Athelete> AtheleteRecords { get; set; }

        // Constructor
        public JavelinThrow()
        {
        }


        //Methods
        //public static List<Athelete> AddAthelete(List<Athelete> AtheleteRecords, string atheleteName, int throwDistance_inMeters)
        //{
        //    foreach (Athelete athelete in AtheleteRecords)
        //    {
        //        //Athelete athelete = new Athelete();
        //        // define each athelete data according to AtheleteInfo properties

        //        athelete.Id += 1;

        //        athelete.Name = atheleteName;

        //        athelete.ThrowDistance_inMeters = throwDistance_inMeters;

        //        athelete.ThrowDistance_inCentimeters = athelete.ThrowDistance_inMeters * 100;

        //        // add athelete to AtheleteRecords
        //        AtheleteRecords.Add(athelete);
        //    }
        //    return AtheleteRecords;
        //}
    }
}