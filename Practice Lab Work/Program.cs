namespace Practice_Lab_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };
            int[] nums2 = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            Console.WriteLine("Linq Lab Numbers: ");
            Console.WriteLine("===================================");
            Console.WriteLine();
            //Prints minimum number in array
            int minValue = nums.Min();
            Console.WriteLine("This is the minimum value: " + minValue);
            Console.WriteLine();
            //Prints Maximum number in array
            int maxValue = nums.Max();
            Console.WriteLine("This is th maximum number: " + maxValue);
            
            Console.WriteLine();

            //Prints numbers greater than 10,000
            List<int> numsUnder10000 = nums.Where(num => num < 10000).ToList();
            Console.WriteLine("Numbers under 10,000: ");
            PrintList(numsUnder10000);
            Console.WriteLine();

            //Prints numbers greater than 10 and less than 100.
            List<int> numBetween1 = nums.Where(num => num >= 10 && num < 100).ToList();
            PrintList(numBetween1);
            Console.WriteLine();

            //Prints numbers between 100,000 < 999,999
            List<int> numBetween2 = nums.Where(num => num > 100000 && num <= 999999).ToList();
            PrintList(numBetween2);
            Console.WriteLine();

            //Prints even numbers
            int allEven = nums.Where(n => n % 2 == 0).ToList().Count();
            Console.WriteLine(allEven);
            Console.WriteLine();

            //Prints numbers from greatest to least.     
            List<int> descendingNums = nums.OrderByDescending(num => num).ToList();
            PrintList(descendingNums);
            Console.WriteLine("\n");

            Console.WriteLine("==================================");
            Console.WriteLine("Linq Lab: Students: \n");

            //initiates list of students to be created.
            List<Student> students = new List<Student>();
            //Content of List
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //Prints students over the age of 21.
            List<Student> over21 = students.Where(s => s.Age > 21).ToList();
            Console.WriteLine("\nStudents over the age of 21 years: ");
            PrintStudents(over21);
            

            //Prints the oldest student.
            int oldest = students.Max(s=>s.Age);
            Console.WriteLine("\nThis is the oldest student: " + oldest);
            Console.WriteLine();
            
            //Prints the youngest student.
            int youngest = students.Min(s => s.Age);
            Console.WriteLine($"\nThe youngest student is: {youngest}");

            //Prints the oldest student UNDER the age of 25.
            List<Student> oldestUnder25 = students.Where(s => s.Age < 25).ToList();
            int oldestUnder25Years = oldestUnder25.Max(s => s.Age);
            Console.WriteLine("\nThe students that are the oldest and under 25 years are: ");
            PrintStudents(oldestUnder25);

            //Prints students over 21 and even
            List<Student> over21AndEven = students.Where( s => s.Age > 21 && s.Age % 2 == 0 ).ToList();
            Console.WriteLine("\nThe students that are over 21 years and are even aged:");
            PrintStudents(over21AndEven);


            //Prints all students ages 13-19
            List<Student> ThreeTo19 = students.Where(s => s.Age >= 13 && s.Age <= 19).ToList();
            PrintStudents(ThreeTo19);

            //All names that start with a vowel
            string vowels = "AEIOUaeiou";

            List<Student> beginsWithVowel = new List<Student>();

                foreach(Student s in students)
            {
                if (vowels.Contains(s.Name[0]))
                {
                    beginsWithVowel.Add(s);
                }
            }
            Console.WriteLine("\nStudents whose names start with a vowel: ");
            PrintStudents(beginsWithVowel);

            //Order student age oldest to youngest
            //int oldestToYoungest = students.Sort();
            List<Student> oldestToYoungest = new List<Student>();


            oldestToYoungest = students.OrderByDescending(s => s.Age).ToList();
                Console.WriteLine($"Students listed in descending order: " );
            foreach ( Student s in oldestToYoungest)
            {
                Console.WriteLine(s.Name + "   " + s.Age);
            }
           
        }

        public static void PrintStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                Student age = students[i];
                Console.WriteLine($" Student: {students[i].Age} Age: {students[i].Name}");
            }
        }


        public static void PrintList(List<int> input)
        {
            for (int i = 0; i < input.Count; i++)
            {
                int nums = input[i];
                Console.WriteLine($"{i}: {nums}");
            }
        }

    }

}
