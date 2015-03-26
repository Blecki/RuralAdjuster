using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace RuralAdjuster.DataModel
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(SchemeEntry))]
    public class Segment
    {
        [IgnoreDataMember]
        public Action OnChanges;

        public void MadeChanges() { if (OnChanges != null) OnChanges(); }

        [DataMember]
        public String Comment;

        [DataMember]
        public Route SourceRoute;
        [DataMember]
        public Route DestinationRoute;

        [DataMember]
        public int RegularBoxes;
        [DataMember]
        public int CentralizedBoxes;
        [DataMember]
        public float Miles;
        [DataMember]
        public int CollectionSlots;
        [DataMember]
        public int ParcelLockers;
        [DataMember]
        public int Dismounts;
        [DataMember]
        public int DismountDistance;

        [DataMember]
        public List<SchemeEntry> Scheme = new List<SchemeEntry>();

        [IgnoreDataMember]
        public float Value
        {
            get
            {
                var boxFactor = SourceRoute.BoxFactor;
                if (SourceRoute.LStatus == LStatus.NonL) boxFactor += 2.0f;
                else boxFactor += 1.82f;

                return (Miles * 12.0f) +
                    (RegularBoxes * boxFactor) +
                    (CentralizedBoxes * (1.0f + SourceRoute.BoxFactor)) +
                    CollectionSlots +
                    (ParcelLockers * 2.0f) +
                    (Dismounts * 0.1f) +
                    (DismountDistance * 0.00429f);
            }
        }

        public String DescriptionString(String prefix)
        {
            return String.Format("{0}{1,7:######.00} : {2} | PRE: R{3:000} POST: R{4:000}",
                SourceRoute == DestinationRoute ? " " : prefix,
                0.0f,
                Comment,
                SourceRoute == null ? -1 : SourceRoute.Number,
                DestinationRoute == null ? -1 : DestinationRoute.Number);
        }

        public String DetailedString(String prefix)
        {
            return String.Format("{7}{0,7:#######} Source:R{8} Destination:R{9} RegBoxes:{1,4:####} CentBoxes:{2,4:####} CSlots:{3,3:###} PLockers:{4,3:###} Dismounts:{5,3:###} Distance:{6,4:####}",
                Value,
                RegularBoxes,
                CentralizedBoxes,
                CollectionSlots,
                ParcelLockers,
                Dismounts,
                DismountDistance,
                SourceRoute == DestinationRoute ? "  " : prefix,
                SourceRoute.ToString(),
                DestinationRoute.ToString());
        }
    }
}
