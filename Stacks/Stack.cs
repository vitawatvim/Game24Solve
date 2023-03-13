using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GUImain;

namespace GUImain
{
    public interface Stack
    {
        bool isEmpty();
        int size();
        void push(object e);
        object peek();
        object pop();
    }

}
