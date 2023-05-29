using System;
using System.Collections.Immutable;

namespace CourseExam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Task1_PhoneNumber
                Console.WriteLine("\n---Task 1_Validate Phone Number---\n");

                Console.WriteLine("Enter Phone Number (example input : 123456789) ");
                string userInput = Console.ReadLine();

                bool phoneNumberIsValid = ValidatePhoneNumber(userInput);
                Console.WriteLine($"Is the Phone Number in valid format ? : {phoneNumberIsValid}");
                Console.WriteLine("\n---End Task 1_Validate Phone Number----\nPress any key to continue...");
                _ = Console.ReadKey();
                Console.Clear();
                #endregion



                #region Task2_GenerateUserName
                Console.WriteLine("\n---Task 2_Generate Username---\n");
                Console.WriteLine("Enter full name : \n(example input: firstname lastname) ");

                // split user input to string array
                string[] nameArray = Console.ReadLine().Split(' ');
                string firstname = nameArray[0];
                string lastname = nameArray[1];

                // call method and print return variable
                string username = GenerateUserName(firstname, lastname);
                Console.WriteLine($"\nUser : {firstname} {lastname}\nUsername : {username}");
                Console.WriteLine("\n---End Task 2_Generate Username---\nPress any key to continue...");
                _ = Console.ReadKey();
                Console.Clear();
                #endregion



                #region Task3_JavelinThrow
                Console.WriteLine("\n---Task 3_Javelin Throw---\n");

                // initialize list and userExit option
                List<JavelinThrow> athelete = new List<JavelinThrow>();
                bool userExit = false;

                // iterate user input till userExit=true
                while (!userExit)
                {
                    Console.WriteLine("Enter Athelete full name : ");
                    string atheleteName = Console.ReadLine();

                    Console.WriteLine("Enter Athelete's Throw distance (in meters) : ");
                    double throwDistance_inMeters = double.Parse(Console.ReadLine());
                    double throwDistance_inCentimeters = throwDistance_inMeters * 100;

                    // pack data in Javelin Throw class object
                    JavelinThrow throwData = new JavelinThrow(atheleteName, throwDistance_inMeters, throwDistance_inCentimeters);
                    
                    // add throwData to athelete
                    athelete.Add(throwData);
                    
                    // confirm user input to add or exit
                    Console.WriteLine("Press 'enter' to add more atheletes or 'e' to exit");
                    userExit = Console.ReadLine() == "e" ? true : false;
                    Console.Clear();
                }

                // iterate and present user input data
                Console.WriteLine("~\t\t\t\n----Javelin Throws----~\nAtheleteID\tAthelete Name\t\tThrow Distance (in meters)\t\tThrow Distance (in centimeters)");
                // iterate each throw from athelete List
                for (int i = 0; i < athelete.Count; i++)
                {
                    Console.WriteLine($"{i + 1}\t\t{athelete[i].Name}\t\t\t{Math.Round(athelete[i].ThrowDistance_inMeters, 2)}\t\t\t\t\t{Math.Round(athelete[i].ThrowDistance_inCentimeters, 2)}");
                }

                Console.WriteLine("\n---End Task 3_Javelin Throw---\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
                #endregion



                #region Task4_Product
                Console.WriteLine("\n---Task4_Product---\n");

                // initialize products list
                List<Product> productsList = new List<Product>();
                decimal productsTotal = 0.0m;

                // iterate user input for product name
                bool endList = false;
                while (!endList)
                {
                    // add products to productsList
                    Console.WriteLine("Enter the name of product to buy : ");
                    Product item = new Product(Console.ReadLine());
                    productsList.Add(item);

                    // confirm user input to add or exit
                    Console.Write("Would you like to add more : Press 'enter' to add, 'e to exit");
                    endList = Console.ReadLine() == "e" ? true : false;
                    Console.Clear();
                }

                // print products information - id, name, price and discount price
                Console.WriteLine("\n\t\t\t~----Products in the Basket----~\nProduct ID\tProduct Name\t\tProduct Original Price\t\tProduct Discounted Price");
                foreach (var item in productsList)
                {
                    decimal discountPrice = item.GetDiscountPrice(item.Price);
                    Console.WriteLine($"{item.Id}\t\t{item.Name}\t\t\t{item.Price}\t\t\t{discountPrice}");

                    // sum productsTotal with discountPrice
                    productsTotal += discountPrice;
                }

                // print productsTotal
                Console.WriteLine($"Total to pay after 20% discount on all products : {productsTotal} Euro");
                Console.WriteLine("\n---End Task4_Product---\nPress any key to continue...");
                #endregion

            }
            catch (Exception ex) { Console.WriteLine($"\n\nPlease check you error below:\n{ex.Message}"); }

        }


        // Task1
        public static bool ValidatePhoneNumber(string userString)
        {
            string phoneNumber = "+358";
            bool validNumber;
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
                Console.WriteLine($"Number entered {phoneNumber} is NOT accepted.");
                validNumber = false;
            }
            return validNumber;
        }

        // Task2
        public static string GenerateUserName(string firstname, string lastname)
        {
            string username = string.Empty;
            try 
            { 
                if (firstname != null && lastname != null && firstname.Length > 3 && lastname.Length > 5)
                {
                    username += firstname.Substring(0, 3);       // substring first 3 letters of firstname
                    username += lastname.Substring(0, 5);       // substring first 5 letters of firstname
                }
                else if (firstname != null && lastname != null && firstname.Length <= 3 && lastname.Length <= 5)
                {
                    username = firstname + lastname; 
                }
                else if (firstname != null && lastname != null && firstname.Length <= 3 && lastname.Length > 5)
                {
                    username = firstname + lastname.Substring(0, 5);
                }
                else if (firstname != null && lastname != null && firstname.Length > 3 && lastname.Length <= 5)
                {
                    username = firstname.Substring(0, 3) + lastname;
                }
            }
            catch (Exception ex) { Console.WriteLine($"ERROR : {ex.Message}\n---Terminate Program---\n"); }

            return username;
            
        }


    }
}