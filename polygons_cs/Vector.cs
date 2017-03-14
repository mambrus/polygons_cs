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
  }
}

