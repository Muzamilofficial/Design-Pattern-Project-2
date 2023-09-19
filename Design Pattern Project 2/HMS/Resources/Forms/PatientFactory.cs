using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS.Resources.Forms
{
    abstract class PatientFactory
    {
        public abstract SurgeryPatient createSurgeryPatient();
        public abstract GeneralPatient createGeneralPatient();
    }
}
