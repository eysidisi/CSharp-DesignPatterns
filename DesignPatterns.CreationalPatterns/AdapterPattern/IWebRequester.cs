using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CreationalPatterns.AdapterPattern
{
    public interface IWebRequester
    {
        int Request(object obj);
    }
}
