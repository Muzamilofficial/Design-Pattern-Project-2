using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HMS.Resources.Classes;

namespace HMS.Resources.Forms
{
    abstract class SurgeryPatient
    {
        public abstract string addPatient(string _Pswd, string _name, string _fName, string _disease, string _age, string _gender, string _cnum);

    }
}
