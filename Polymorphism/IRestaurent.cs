using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    public interface IRestaurent
    {
        void rooms();
        double rooms(double capa,double seat);
        double rooms(double capa, double seat,double cost);
    }
}
