using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS.Resources.Forms
{
    class OPDPatient:PatientFactory
    {
        public override SurgeryPatient createSurgeryPatient()
        {
            return new SurgeryOPDPatient();
        }
        public override GeneralPatient createGeneralPatient()
        {
            return new GeneralOPDPatient();
        }
    }
}
