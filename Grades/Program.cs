using System;
using System.Collections.Generic;
using System.Speech.Synthesis;
using System.Xml;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("hello  Tenzin Lunten, thank you for taking shower.");
            ////synth.Speak("Jack Jack and Mr. Incredible is angry now as Tenzin Lunten is not taking shower");
            ////synth.Speak("It is on the verge of defeat");
            System.Xml.XmlWriter sys;



            ////String d = "apple";
            ////String e = "APPLE";

            ////Boolean equals = d.Equals(e, StringComparison.CurrentCulture);
            ////Console.WriteLine(equals);

            //String line = " cr7";
            //line = line.Trim(); // this thing doesnt modifies but returns a string.
            //Console.WriteLine(line);

            //DateTime dateNow = new DateTime(2018, 5, 14);
            //Console.WriteLine(dateNow);

            //dateNow = DateTime.Now;
            //Console.WriteLine(dateNow);

            //// stats.lowScore();

            //Arrays();

            ////Ctrl + k + c(comment) and Ctrl + k + u(uncomment)

            ////default is double and not float
            GradeBook book = new GradeBook();
            book.AddGrade(91f);
            book.AddGrade(89.5f);
            book.AddGrade(75.5f);

            GradeStatistics stats = book.ComputeStatistics();

            //book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.Name = "Tenzin's book";
   
            book.NameChanged += OnNameChanged;
            book.NameChanged += OnNameChanged2;
            book.Name = "Tenzin's book 2";

            //book.NameChanged = new NameChangedDelegate(OnNameChanged2);
            //An unknown or someone could do this code which would wipeout all three lines of code before it

            // So, we have to use events and to use it we just need to add event before the delegate name, then this 
            // last code of initializing is not valid in events.

            // The correct way in event is to have two parameters: 1.senders object   2. encapsulated object   


            Console.WriteLine("Average Score: " + stats.averageGrade);
            Console.WriteLine("Lowest Score: " + stats.lowestGrade);
            Console.WriteLine("Highest Score: " + stats.highestGrade);

           
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("Name changed from {0} to {1}", args.oldName, args.newName);
        }

        private static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("!!!");
        }

        private static void Arrays()
        {
            const int numberOfStudents = 4; //what 'const' does is that it is like fina
            float[] grades = new float[numberOfStudents];

            addGrades(grades);

            foreach (int grade in grades) // in java   for(int grade: grades)
            {
                Console.WriteLine(grade);   
            }

        }

        private static void addGrades(float[] grades)
        {
            if (grades.Length <= 4)
            {
                grades[0] = 91f;
                grades[1] = 89.1f;
                grades[2] = 75f;
            }
        }

        private static void WriteBytes(float value)
        {
            byte[] bytes = BitConverter.GetBytes(value);
            foreach (byte b in bytes) {
                Console.Write("X", b); // X in the parenthesis works as a format specifier
            }
        }
    }    
}
