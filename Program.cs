class Program
    {
        static void Main(string[] args)
        {
            // Creating a multi-dimensional array to store student information
            string[,] studentInfo = new string[3, 3];

            // Adding student information to the array
            studentInfo[0, 0] = "Victor Masakada";
            studentInfo[0, 1] = "M";
            studentInfo[0, 2] = "07.05.1990";

            studentInfo[1, 0] = "Lusukama Selemani";
            studentInfo[1, 1] = "M";
            studentInfo[1, 2] = "07.01.1982";

            studentInfo[2, 0] = "Nonhlanhla Empangeni";
            studentInfo[2, 1] = "F";
            studentInfo[2, 2] = "07.05.1992";

            // Displaying the student information
            Console.WriteLine("Student Information:");
            for (int i = 0; i < studentInfo.GetLength(0); i++)
            {
                Console.WriteLine($"Student {i + 1}:");
                Console.WriteLine($"Name: {studentInfo[i, 0]}");
                Console.WriteLine($"Gender: {studentInfo[i, 1]}");
                Console.WriteLine($"DOB: {studentInfo[i, 2]}");
                Console.WriteLine();
            }
        }
    }

