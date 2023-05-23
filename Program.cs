using System.Collections.Immutable;

namespace CourseExam
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Task1_PhoneNumber
            Console.WriteLine("\n---Task 1---\n");

            Console.WriteLine("Enter Phone Number (example input : 123456789) ");
            string userInput = Console.ReadLine();

            bool phoneNumberIsValid = ValidatePhoneNumber(userInput);
            Console.WriteLine($"Phone Number is in valid format : {phoneNumberIsValid}");


            #endregion

            #region Task2_GenerateUserName
            Console.WriteLine("\n---Task 2---\n");
            Console.WriteLine("Enter full name : \n(example input: firstname lastname) ");
            string[] nameArray = Console.ReadLine().Split(' ');
            string firstname = nameArray[0];
            string lastname = nameArray[1];
            Console.WriteLine(GenerateUserName(firstname, lastname));
            Console.WriteLine("\n---End Task 2---\n");
            #endregion

            #region Task3_JavelinThrow
            Console.WriteLine("\n---Task 3---\n");
            
            Console.WriteLine("Enter Athelete full name : ");
            string atheleteName = Console.ReadLine();

            Console.WriteLine("Enter Athelete's Throw distance (in meters) : ");
            int throwDistance_inMeters = int.Parse(Console.ReadLine());

            List<JavelinThrow> athelete = new List<JavelinThrow>();
            JavelinThrow throwData = new JavelinThrow();
            throwData.Id += 1;
            throwData.Name = atheleteName;
            throwData.ThrowDistance_inMeters = throwDistance_inMeters;
            throwData.ThrowDistance_inCentimeters = throwDistance_inMeters * 100;

            athelete.Add(throwData);

           foreach (JavelinThrow item in athelete)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.ThrowDistance_inMeters);
                Console.WriteLine(item.ThrowDistance_inCentimeters);
            }

            Console.WriteLine("\n---End Task 3---\n");
            #endregion
        }


        public static bool ValidatePhoneNumber(string userString)
        {
            Console.WriteLine("\n---Task 1---\n");
            string phoneNumber = "+358";
            bool validNumber = false;
            while (!validNumber)
            {                               
                // verify all characters within 0-9
                char[] numbersArray = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                for (int i = 0; i < userString.Length; i++)
                {
                    foreach (char c in numbersArray)
                    {
                        if (userString[i] == c && phoneNumber.Length != 13)
                        {
                            phoneNumber += c.ToString();
                        }
                    }
                }
                // verify final length of phoneNumber
                if (phoneNumber.Length == 13)
                {
                    Console.WriteLine($"Number entered {phoneNumber} is accepted.");
                    validNumber = true;
                }
                else
                {
                    Console.WriteLine($"Number entered {phoneNumber} is NOT accepted. Try again until it is accepted :D");
                    validNumber = false;
                }                             
            }
            Console.WriteLine("\n---End Task 1---\n");
            return validNumber;
        }


        public static string GenerateUserName(string firstname, string lastname)
        {
            Console.WriteLine("\n---Task 2---\n");
            string username = string.Empty;
            username += firstname.Substring(0, 3);       // substring first 3 letters of firstname
            username += lastname.Substring(0, 5);       // substring first 5 letters of firstname
            Console.WriteLine($"\nUser : {firstname} {lastname}\nUserName : {username}");

            Console.WriteLine("\n---End Task 2---\n");
            return username;
        }
    }
}