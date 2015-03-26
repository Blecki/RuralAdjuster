using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace RuralAdjuster.DataModel
{
    [DataContract]
    [KnownType(typeof(Route))]
    public class Zone
    {
        [DataMember]
        public int Zipcode;

        [DataMember]
        public List<Route> Routes = new List<Route>();

        private static int CompareRoutes(Route a, Route b)
        {
            return b.Number - a.Number;
        }

        public void SortRoutes()
        {
            Routes.Sort(CompareRoutes);
        }
    }
}
