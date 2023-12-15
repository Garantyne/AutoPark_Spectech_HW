using AutoPark_Spectech_HW.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoPark_Spectech_HW.Service
{
    internal class TechManager : IEnumerable<TechAuto>
    {
        public List<TechAuto> TechList { get; set; }

        public TechManager() { TechList = new List<TechAuto>(); }
        public TechManager(string tech, string type)
        {
            if (tech == null)
            {
                TechList = new List<TechAuto>();
            }
            TechList.Add(new TechAuto(tech, type));
        }

        public void AddTech(string tech, string type)
        {
            TechList.Add(new TechAuto(tech, type));
        }

        public List<TechAuto> GetTechList()
        {
            return TechList;
        }

        public List<TechAuto> DeleteTech(int i)
        {
            //TechAuto t = new TechAuto() { TechName = tech };
            if (TechList[i] != null)
            {
                TechList.RemoveAt(i);
                return TechList;
            }
            return TechList;
        }

        public IEnumerator<TechAuto> GetEnumerator()
        {
            return TechList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
