using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace RuralAdjuster.DataModel
{
    public class Operations
    {
        public static void MoveSegment(Segment Segment, Route to)
        {
            Segment.DestinationRoute.PostSegments.Remove(Segment);
            to.PostSegments.Add(Segment);
            Segment.DestinationRoute = to;
        }

        public static void DeleteSegment(Segment Segment)
        {
            Segment.SourceRoute.PreSegments.Remove(Segment);
            Segment.DestinationRoute.PostSegments.Remove(Segment);
        }

        public static void Serialize(Zone zone, String filename)
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Zone));
            var stream = new System.IO.FileStream(filename, System.IO.FileMode.Create, System.IO.FileAccess.Write);
            var settings = new XmlWriterSettings { Indent = true };

            using (var w = XmlWriter.Create(stream, settings))
                serializer.WriteObject(w, zone);

            stream.Close();
        }

        public static Zone Deserialize(String filename)
        {
            var serializer = new System.Runtime.Serialization.DataContractSerializer(typeof(Zone));
            var stream = new System.IO.FileStream(filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            var result = serializer.ReadObject(stream);
            return result as Zone;
        }
    }
}
