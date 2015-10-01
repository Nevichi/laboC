using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pup1 = new Pupil("Quentin", 5);
            /*Activity act1 = new Activity("sieste", true);
            Activity act2 = new Activity("bricolage", false);
            Activity act3 = new Activity("récré", false);
            Activity act4 = new Activity("sport", true);
            Activity act5 = new Activity("piscine", true);*/
            List<Pupil> LstPupil = new List<Pupil>();
            /*{
                new Pupil("Kuan ti", 7),
                new Pupil("Roland", 5),
                new Pupil("Gioele", 4),
                new Pupil("Paola", 6),
                new Pupil("Hua", 7),
                new Pupil("Ian", 5),
                new Pupil("Frieda", 6),
                new Pupil("Terrence", 7),
                new Pupil("Raluca", 4),
            };*/

            var pupilGrade1Plus6 = LstPupil.TakeWhile(p => p.Age > 6);

            if (pupilGrade1Plus6 != null)
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                }

            Pupil pup2 = new Pupil("Kuan ti", 6);
            Pupil pup3 = new Pupil("Roland", 5);
            Pupil pup4 = new Pupil("Gioele", 4);
            Pupil pup5 = new Pupil("Paola", 6);
            Pupil pup6 = new Pupil("Hua", 7);
            Pupil pup7 = new Pupil("Ian", 5);
            Pupil pup8 = new Pupil("Frieda", 6);
            Pupil pup9 = new Pupil("Terrence", 5);
            Pupil pup10 = new Pupil("Raluca", 4);

            pup1.AddActivity("sieste");
            pup1.AddActivity("récré");
            pup1.AddActivity("bricolage");
            pup1.AddActivity("sport");
            pup1.AddActivity("piscine");
            pup1.AddEvaluation("sieste");
            pup1.AddEvaluation(evaluation: 'T', title: "récré");


            System.Console.Write(pup1);
            System.Console.Read();
        }
    }
}
