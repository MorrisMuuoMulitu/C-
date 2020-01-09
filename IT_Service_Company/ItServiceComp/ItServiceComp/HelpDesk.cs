using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItServiceComp
{
    class HelpDesk:Employee
    {
        //properties
        public string Language { get; private set; }
        public string LanguageCertCode { get; private set; }
        public int numberOfCalls { get; private set; }
        public static int CommissionMultiplier { get; set; }

        //constructor
        public HelpDesk(string name,int birthYear,string language,string languageCertCode) : base(name, birthYear)
        {
            this.Language = language;
            this.LanguageCertCode = languageCertCode;
        }
        //methods
        public void Call()
        {
            numberOfCalls++;
        }
        public override int Income()
        {
            return base.Income()+numberOfCalls*CommissionMultiplier;
        }
        public override string ToString()
        {
            return base.ToString()+ "\n          language knowledge: "+ Language;
        }
    }
}
