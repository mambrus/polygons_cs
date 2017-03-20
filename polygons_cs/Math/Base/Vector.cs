namespace polygons_cs.Math.Base
{
    class Vector<T>
    {
        private T[] m_v;

        protected Vector()
        {
            throw new System.NotImplementedException();
        }

        public Vector(int size)
        {
            m_v = new T[size];
        }

        // Arrays not decaying to pointers as in C/C++ is a nice feature.
        // Corresponding in C/C++ would require macro trickey.
        public Vector(T[] d)
        {
            m_v = new T[d.Length];
            Assign(d);
        }

        //C# lacks overloadable assignement operator ('=')
        public Vector<T> Assign(T[] d)
        {
            if (d.Length != m_v.Length)
            {
                throw (new VectorException("Assignement from array with different lengt is illegal"));
            }

            for (int i = 0; i < d.Length; i++)
            {
                m_v[i] = d[i];
            }
            return this;
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
    }
}