﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using polygons_cs.Math.LinearAlgebra;
using polygons_cs.Math.Base;

namespace polygons_cs
{
  class Program
  {
    static void Main(string[] args)
    {

      try
      {
        #region One dimensional

        Math.LinearAlgebra.Vector<int> A = new
          Math.LinearAlgebra.Vector<int>(
            new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10});

        // Make sure the invariant apply to the collection, not it's content
        A[3] = 77;
        A[3] = 78;

        Math.LinearAlgebra.Vector<int> G;
        //Can we assign G twice with the vector of the same size?
        G = A;
        G = A;

        //Yepp, but different size?
        Math.LinearAlgebra.Vector<int> X = new
          Math.LinearAlgebra.Vector<int>(
            new int[] { 1, 2, 3 });

        // Hmm, this was supposed to break. Oh well, I didn't trust the immutable concept anyway...
        G = X;


        //using the first indexer with int parameter to print int Vector
        for (int i = 0; i < A.Lenght; i++)
        {
          Console.WriteLine("A[" + i + "]: " + A[i] +", "+ "G[" + i + "]: " + G[i]);
        }
        Console.WriteLine();

        // Linear algebra arithmetic int test
        Math.LinearAlgebra.Vector<int> C = A + A; //<-- HEPP!
        for (int i = 0; i < C.Lenght; i++)
        {
          Console.WriteLine("C[" + i + "]: " + C[i]);
        }
        Console.WriteLine();


        Math.LinearAlgebra.Vector<double> B =
          new Math.LinearAlgebra.Vector<double>(
            new double[] {1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9, 10.0});


        //using the first indexer with int parameter to print float Vector
        for (int i = 0; i < B.Lenght; i++)
        {
          Console.WriteLine("B[" + i + "]: " + B[i]);
        }
        Console.WriteLine();


        // Linear algebra arithmetic double test
        Math.LinearAlgebra.Vector<double> D = B + B; //<-- HEPP!
        for (int i = 0; i < D.Lenght; i++)
        {
          Console.WriteLine("D[" + i + "]: " + D[i]);
        }
        Console.WriteLine();

        #endregion

        #region Multi-dimentional

        // Pure Base.Vector until LA operations for multidementional
        // Vectors are implemented (TBD)

        Math.Base.Vector<Math.Base.Vector<double>> M =
          new Math.Base.Vector<Math.Base.Vector<double>>(
            new Math.Base.Vector<double>[] {B, D, B + B, B + D, D - B, B - B});

        //using the first indexer with int parameter to print float Vector
        for (int i = 0; i < M.Lenght + 1; i++)
        {
          for (int j = 0; j < B.Lenght; j++)
          {
            Console.WriteLine("M[" + i + "][" + j + "]: " + M[i][j]);
          }
        }
        Console.WriteLine();
      }
      catch (VectorException e)
      {
        Console.WriteLine("Vector exception: <<{0}>>", e.Message);
      }

      #endregion

      Console.ReadKey();
    }
  }
}
