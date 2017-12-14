using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLanguageGeneralProof
{
    class Program
    {
        static void Main(string[] args)
        {
            Organization org = new Company();
        }
    }

    class Organization
    {
        public Organization()
        {

        }
    }

    class Company : Organization
    {
        public Company() : this(33)
        {

        }

        public Company(int staff)
        {
            
        }
    }
}
