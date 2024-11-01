using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace oyunum
{
    public class Mayin
    {
        Point bomb_location;
        bool bomb_isemty;
        bool dolu;
        bool bakildi;
        public Mayin(Point location)
        {
            dolu = false;
            bomb_location = location;
        }
        public Point get_Bomblocation
        {
            get{
                return bomb_location;
            }
        }
        public bool istherebomb
        {
            get{ return dolu; }
            set { dolu=value; }
        }
        public bool bakildi_
        {
            get { return bakildi; }
            set { bakildi = value; }
        }
    }
}
