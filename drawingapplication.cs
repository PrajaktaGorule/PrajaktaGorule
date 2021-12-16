using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace soloLearnproject
{
    class drawingapplication
    {
        static void Main(string[] args)
        {
            Draw pencil = new Draw();
            Brush brush = new Brush();
            Spray spray = new Spray();

            pencil.StartDraw();
            brush.StartDraw();
            spray.StartDraw();
            Console.ReadLine();

        }
    }

    /*
    Draw => "Using pencil"
    Brush => "Using brush"
    Spray => "Using spray"
    */

    public interface IDraw
    {
        void StartDraw();
    }

    class Draw : IDraw
    {
        public virtual void StartDraw()
        {
            Console.WriteLine("Using pencil");
        }
    }

    //inherit this class from the class Draw
    class Brush : IDraw
    {
        //implement the StartDraw() method
        public virtual void StartDraw()
        {
            Console.WriteLine("Using brush");
        }

    }

    //inherit this class from the class Draw
    class Spray : IDraw
    {
        //implement the StartDraw() method
        public virtual void StartDraw()
        {
            Console.WriteLine("Using spray");
        }
    }
}

