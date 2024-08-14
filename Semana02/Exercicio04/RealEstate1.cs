using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class RealEstate1
    {
        private string _address;
        public ReaLEstate(string address)
        {
            _address = address;
        }
        public string Address { 
            get => _address;
            set => _address = value;
        }
    }
}