using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polygons_cs
{
  class Vector<VTYPE>
  {
    private VTYPE[] m_v;

    public Vector(int size)
    {
      m_v = new VTYPE[size];
    }

    public int size()
    {
      return m_v.Length;
    }

    public VTYPE this[int index]
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
    public static Vector<VTYPE> operator +(Vector<VTYPE> lhs, Vector<VTYPE> rhs)
    {
      Vector<VTYPE> ret = new Vector<VTYPE>(lhs.size());

      if (rhs.size() != lhs.size())
      {
        throw (new VectorException("Vectors must be of the same dimension to be added with each other"));
      }
      for (int i = 0; i < lhs.size(); i++)
      {
        ret[i] = lhs[i] + rhs[i];
      }
      return ret;
    }

    // Overload - operator: 2 vectors
    public static Vector<VTYPE> operator -(Vector<VTYPE> lhs, Vector<VTYPE> rhs)
    {
      Vector<VTYPE> ret = new Vector<VTYPE>(lhs.size());

      if (rhs.size() != lhs.size())
      {
        throw (new VectorException("Vectors must be of the same dimension to be added with each other"));
      }
      for (int i = 0; i < lhs.size(); i++)
      {
        ret[i] = lhs[i] - rhs[i];
      }
      return ret;
    }

    // Overload + operator: vector + element
    public static Vector<VTYPE> operator +(Vector<VTYPE> lhs, VTYPE rhs)
    {
      Vector<VTYPE> ret = new Vector<VTYPE>(lhs.size());

      for (int i = 0; i < lhs.size(); i++)
      {
        ret[i] = lhs[i] + rhs;
      }
      return ret;
    }

    // Overload - operator: vector - element
    public static Vector<VTYPE> operator -(Vector<VTYPE> lhs, VTYPE rhs)
    {
      Vector<VTYPE> ret = new Vector<VTYPE>(lhs.size());


      for (int i = 0; i < lhs.size(); i++)
      {
        ret[i] = lhs[i] - rhs;
      }
      return ret;
    }
    */

  }
}


