using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygons_cs
{
  class Program
  {
    static void Main(string[] args)
    {

      try
      {
        Vector<int> myVector = new Vector<int>(10);

        myVector[0] = 1;
        myVector[1] = 2;
        myVector[2] = 3;
        myVector[3] = 4;
        myVector[4] = 5;
        myVector[5] = 6;
        myVector[6] = 7;
        myVector[7] = 8;
        myVector[8] = 9;
        myVector[9] = 10;

        //using the first indexer with int parameter to print int Vector
        for (int i = 0; i < myVector.Lenght(); i++)
        {
          Console.WriteLine(i + ": " + myVector[i]);
        }

        Vector<double> myVector2 = new Vector<double>(10);

        myVector2[0] = 1.1;
        myVector2[1] = 2.2;
        myVector2[2] = 3.3;
        myVector2[3] = 4.4;
        myVector2[4] = 5.5;
        myVector2[5] = 6.6;
        myVector2[6] = 7.7;
        myVector2[7] = 8.8;
        myVector2[8] = 9.9;
        myVector2[9] = 10.0;

        //using the first indexer with int parameter to print float Vector
        for (int i = 0; i < myVector2.Lenght(); i++)
        {
          Console.WriteLine(i + ": " + myVector2[i]);
        }

        Vector<Vector<double>> myVector3 = new Vector<Vector<double>>(10);

        myVector3[0] = myVector2;
        myVector3[1] = myVector2;
        myVector3[2] = myVector2;
        myVector3[3] = myVector2;
        myVector3[4] = myVector2;
        myVector3[5] = myVector2;
        myVector3[6] = myVector2;
        myVector3[7] = myVector2;
        myVector3[8] = myVector2;
        myVector3[9] = myVector2;

        //using the first indexer with int parameter to print float Vector
        for (int i = 0; i < myVector3.Lenght(); i++)
        {
          for (int j = 0; j < myVector2.Lenght() + 1; j++)
          {
            Console.WriteLine("[" + i + "][" + j + "]: " + myVector3[i][j]);
          }
        }
      }
      catch (VectorException e)
      {
        Console.WriteLine("Vector exception: <<{0}>>", e.Message);
      }

      Console.ReadKey();
    }
  }
}

