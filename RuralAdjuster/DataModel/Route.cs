using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace RuralAdjuster.DataModel
{
    public enum LStatus
    {
        L,
        NonL
    }

    [DataContract(IsReference = true)]
    [KnownType(typeof(Segment))]
    public class Route
    {
        [IgnoreDataMember]
        public Action OnChanged;

        [DataMember] public int Number;

        [DataMember] public List<Segment> PreSegments = new List<Segment>();
        [DataMember] public List<Segment> PostSegments = new List<Segment>();

        [DataMember]
        public int PreEvaluation;
        [DataMember]
        public int TargetEvaluation = 2844;

        [DataMember]
        public float SuitableAllowance;

        [DataMember]
        public float BoxFactor;
        [DataMember]
        public LStatus LStatus;

        [DataMember]
        public int RegularBoxes;
        [DataMember]
        public int CentralizedBoxes;
        [DataMember]
        public int CollectionSlots;
        [DataMember]
        public int ParcelLockers;
        [DataMember]
        public int Dismounts;
        [DataMember]
        public int DismountDistance;
        [DataMember]
        public float PreMiles;
        [DataMember]
        public float PostMiles;
        [DataMember]
        public int LockedPouchStops;

        public float NewEvaluation
        {
            get
            {
                float newValue = PreEvaluation;
                foreach (var Segment in PreSegments)
                    if (Segment.SourceRoute != Segment.DestinationRoute)
                        newValue -= Segment.Value;
                foreach (var Segment in PostSegments)
                    if (Segment.SourceRoute != Segment.DestinationRoute)
                        newValue += Segment.Value;
                return newValue;
            }
        }

        internal Segment CreateNewSegment()
        {
            var r = new Segment();
            r.SourceRoute = this;
            r.DestinationRoute = this;
            PreSegments.Add(r);
            PostSegments.Add(r);
            return r;
        }

        public override string ToString()
        {
            return String.Format("R{0,3:000}", Number);
        }

        public String DescriptionString()
        {
            return String.Format("{6} Pre-Eval: {0} ({1}) Post-Eval: {2} ({3}) Target-Eval: {4} ({5})",
                Evaluation.ToStringEvaluation(PreEvaluation),
                Evaluation.Name(PreEvaluation),
                Evaluation.ToStringEvaluation(NewEvaluation),
                Evaluation.Name(NewEvaluation),
                Evaluation.ToStringEvaluation(TargetEvaluation),
                Evaluation.Name(TargetEvaluation),
                this.ToString());
        }
    }
}
