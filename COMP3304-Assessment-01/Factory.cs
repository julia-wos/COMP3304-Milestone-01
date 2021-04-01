using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP3304_Assessment_01
{
    //Generic Factory pattern provided by Marc Price
    public class Factory<E> : IFactory<E>
    {
        public E Create<T>() where T : E, new()
        {
            return new T();
        }
    }
}
