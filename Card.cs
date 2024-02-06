using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTo21
{
    public class Card
    {
        public string ID;
        public string name; //todo: store the name for each card alongside the ID

        public string GetName()
        {
            //todo:figure out what the name should be base on id
            return name;
        }
    }
}
