using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark_Spectech_HW.Entity
{
    internal class TechAuto
    {
        public string TechName {  get; set; }
        public string TechType { get; set;}

        public TechAuto() { }

        public TechAuto(string TechName, string TechType)
        {
            this.TechName = TechName;
            this.TechType = TechType;
        }
        public override string ToString()
        {
            return $"{TechName} {TechType, 60}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is TechAuto)
            {
                return TechName == ((TechAuto)obj).TechName || TechType == ((TechAuto)obj).TechType ;
            }
            throw new ArgumentException("Тип не соответствует");
        }

    }
}
