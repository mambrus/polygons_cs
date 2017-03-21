using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using polygons_cs.Math.Base;

namespace polygons_cs.Math.LinearAlgebra
{

  #region constructors

  class Vector<T> : Base.Vector<T> where T : IComparable
  {
    // Re-implement base-class public constructor (bacause
    // language requires it)
    public Vector(int size) : base(size)
    {
    }

    public Vector(T[] d) : base(d)
    {
    }

    #endregion

    #region operators

    // Overload + operator, 2 vectors
    public static Vector<T> operator +(Vector<T> lhs, Vector<T> rhs)
    {
      Vector<T> ret = new Vector<T>(lhs.Lenght);

      if (rhs.Lenght != lhs.Lenght)
      {
        throw (new VectorException(
          "Vectors must be of the same size to be added"));
      }
      for (int i = 0; i < lhs.Lenght; i++)
        ret[i] = (dynamic) lhs[i] + (dynamic) rhs[i];
      return ret;
    }

    // Overload - operator, 2 vectors
    public static Vector<T> operator -(Vector<T> lhs, Vector<T> rhs)
    {
      Vector<T> ret = new Vector<T>(lhs.Lenght);

      if (rhs.Lenght != lhs.Lenght)
      {
        throw (new VectorException(
          "Vectors must be of the same size to be subtracted"));
      }
      for (int i = 0; i < lhs.Lenght; i++)
        ret[i] = (dynamic) lhs[i] - (dynamic) rhs[i];
      return ret;
    }
  }

  #endregion
}
