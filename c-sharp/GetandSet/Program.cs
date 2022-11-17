using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// yyyy
/**/
namespace GetAndSet
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Module chemistry = new Module();
            chemistry.setData(90, 85, 0.4);
            Module english = new Module(70, 80, 0.4);

            int fEnglish = finalMark(english);
            int fChem = finalMark(chemistry);

        }

        static int finalMark(Module subject)
        {
            int cw = subject.getCW();
            int ex = subject.getEx();
            double exwt = subject.getExwt();

            double score = (cw * (1-exwt)) + (ex * exwt);

            Console.WriteLine("Coursework score is " + cw + " exam score is "+ ex + " final score is " + (int)score);
            return (int)score;
        }
    }

    class Module
    {
        private int coursework, exam;
        private double examweighting;

        public void setData(int coursework, int ex, double exwt)
        {
            this.coursework = coursework;
            exam = ex;
            examweighting = exwt;
        }

        public Module()
        {
            coursework = 0;
            exam = 0;
            examweighting = 0.0;
        }
        public Module(int cw, int ex, double exwt)
        {
            coursework = cw;
            exam = ex;
            examweighting = exwt;
        }

        
        public int getCW()
        {
            return coursework;
        }

        public int getEx()
        {
            return exam;
        }

        public double getExwt()
        {
            return examweighting;
        }
    }
}
