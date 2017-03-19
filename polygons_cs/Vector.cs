using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygons_cs
{
  class Vector<T>
  {
    private T[] m_v;

    public Vector(int size)
    {
      m_v = new T[size];
    }

    public int Lenght()
    {
      return m_v.Length;
    }

    public T this[int index]
    {
      get
      {
        if (index >= 0 && index < m_v.Length)
        {
          return m_v[index];
        }
        else
        {
          throw (new VectorException("Index out of boundaries"));
        }
      }
      set
      {
        if (index >= 0 && index < m_v.Length)
        {
          m_v[index] = value;
        }
        else
        {
          throw (new VectorException("Index out of boundaries"));
        }
      }
    }

    // Linear Algebra operators
    // ========================
    /*
    // Overload + operator, 2 vectors
    public static Vector<T> operator +(Vector<VTYPE> lhs, Vector<VTYPE> rhs)
    {
      Vector<T> ret = new Vector<VTYPE>(lhs.Lenght());

      if (rhs.Lenght() != lhs.size())
      {
        throw (new VectorException("Vectors must be of the same dimension to be added with each other"));
      }
      for (int i = 0; i < lhs.Lenght(); i++)
      {
        ret[i] = lhs[i] + rhs[i];
      }
      return ret;
    }

    // Overload - operator: 2 vectors
    public static Vector<T> operator -(Vector<VTYPE> lhs, Vector<VTYPE> rhs)
    {
      Vector<T> ret = new Vector<VTYPE>(lhs.Lenght());

      if (rhs.Lenght() != lhs.size())
      {
        throw (new VectorException("Vectors must be of the same dimension to be added with each other"));
      }
      for (int i = 0; i < lhs.Lenght(); i++)
      {
        ret[i] = lhs[i] - rhs[i];
      }
      return ret;
    }

    // Overload + operator: vector + element
    public static Vector<T> operator +(Vector<VTYPE> lhs, VTYPE rhs)
    {
      Vector<T> ret = new Vector<VTYPE>(lhs.Lenght());

      for (int i = 0; i < lhs.Lenght(); i++)
      {
        ret[i] = lhs[i] + rhs;
      }
      return ret;
    }

    // Overload - operator: vector - element
    public static Vector<T> operator -(Vector<VTYPE> lhs, VTYPE rhs)
    {
      Vector<T> ret = new Vector<VTYPE>(lhs.Lenght());


      for (int i = 0; i < lhs.Lenght(); i++)
      {
        ret[i] = lhs[i] - rhs;
      }
      return ret;
    }
    */

  }
}


