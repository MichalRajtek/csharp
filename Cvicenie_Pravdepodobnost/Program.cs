namespace Cvicenie_Pravdepodobnost
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>();
            students.Add(new Student("Michal", 1));
            students.Add(new Student("Roman", 3));
            students.Add(new Student("Matus", 6));
            students.Add(new  Student("Martin", 8)); 
            students.Add(new Student("IneMeno", 1));

            List<Student> klobucik = new List<Student>();
            foreach (Student stud in students)
            {
                for (int i = 0; i < stud.TicketCount; i++)
                {
                    klobucik.Add(stud);
                }
            }
           
            Random random = new Random();
            int index = random.Next(klobucik.Count);
            Student vyherca = klobucik[index];
            Console.WriteLine(vyherca.Name + vyherca.TicketCount);
        }
    }
}
