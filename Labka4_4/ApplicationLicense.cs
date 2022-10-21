using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labka4_4
{
    internal class ApplicationLicense
    {
        private string KeyId = "";
        private string KeyIdPurs = "GY4HGNC439ROGLAM3CBRTT386UYMCBVNNFG";
        private string KeyIdTrial = "UTY5HGBCMM43187R";
        private Control controlA = new Control();
        public string ControlA
        {
            get { return controlA.ToString(); }
        }
        private enum Control
        {
            Trial,
            Pro,
            Common
        }
        void AllowTrial()
        {
            Console.WriteLine("Триальний режим");
            controlA = Control.Trial;
        }
        void AllowPro()
        {
            Console.WriteLine("Платна версія");
            controlA = Control.Pro;
        }
        void AllowCommon()
        {
            Console.WriteLine("Безкоштовна версія");
        }
        public ApplicationLicense(string key)
        {
            Console.WriteLine(controlA);
            if (key == KeyIdPurs)
            {
                this.KeyId = KeyIdPurs;
                AllowPro();
                Console.WriteLine(controlA);
            }
            else if (key == KeyIdTrial)
            {
                this.KeyId = KeyIdTrial;
                AllowTrial();
                Console.WriteLine(controlA);
            }
            else
            {
                AllowCommon();
                Console.WriteLine(controlA);
            }
        }
    }
}
