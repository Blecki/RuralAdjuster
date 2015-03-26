using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace RuralAdjuster.DataModel
{
    public enum SequenceType
    {
        Even,
        Odd,
        Both
    }

    [DataContract]
    public class SchemeEntry
    {
        [DataMember] 
        public String StreetName;
        [DataMember]
        public int Low = 1;
        [DataMember]
        public int High = 99;
        [DataMember]
        public SequenceType SequenceType = SequenceType.Both;
        [DataMember]
        public int BoxCount = 0;

       
    }
}
