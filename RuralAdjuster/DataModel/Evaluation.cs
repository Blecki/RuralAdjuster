using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RuralAdjuster.DataModel
{
    public class Evaluation
    {
        public float Low;
        public float High;

        public Evaluation(float l, float h)
        {
            this.Low = l;
            this.High = h;
        }

        public static Dictionary<String, Evaluation> EvaluationTable = null;

        public static void BuildEvaluationTable()
        {
            if (EvaluationTable != null) return;

            EvaluationTable = new Dictionary<string, Evaluation>();

            EvaluationTable.Add("48k", new Evaluation(ToMinutes(57, 00), ToMinutes(57, 36)));
            EvaluationTable.Add("47k", new Evaluation(ToMinutes(55, 48), ToMinutes(56, 59)));
            EvaluationTable.Add("46k", new Evaluation(ToMinutes(54, 36), ToMinutes(55, 47)));
            EvaluationTable.Add("45k", new Evaluation(ToMinutes(53, 24), ToMinutes(54, 35)));
            EvaluationTable.Add("44k", new Evaluation(ToMinutes(52, 12), ToMinutes(53, 23)));
            EvaluationTable.Add("43k", new Evaluation(ToMinutes(51, 00), ToMinutes(52, 11)));
            EvaluationTable.Add("42k", new Evaluation(ToMinutes(49, 48), ToMinutes(50, 59)));
            EvaluationTable.Add("41k", new Evaluation(ToMinutes(48, 36), ToMinutes(49, 47)));
            EvaluationTable.Add("40k", new Evaluation(ToMinutes(47, 24), ToMinutes(48, 35)));
            EvaluationTable.Add("46j", new Evaluation(ToMinutes(49, 38), ToMinutes(50, 43)));
            EvaluationTable.Add("45j", new Evaluation(ToMinutes(48, 33), ToMinutes(49, 37)));
            EvaluationTable.Add("44j", new Evaluation(ToMinutes(47, 28), ToMinutes(48, 32)));
            EvaluationTable.Add("43j", new Evaluation(ToMinutes(46, 22), ToMinutes(47, 27)));
            EvaluationTable.Add("42j", new Evaluation(ToMinutes(45, 16), ToMinutes(46, 21)));
            EvaluationTable.Add("41j", new Evaluation(ToMinutes(44, 11), ToMinutes(45, 15)));
            EvaluationTable.Add("46h", new Evaluation(ToMinutes(45, 30), ToMinutes(46, 29)));
            EvaluationTable.Add("45h", new Evaluation(ToMinutes(44, 30), ToMinutes(45, 29)));
            EvaluationTable.Add("44h", new Evaluation(ToMinutes(43, 30), ToMinutes(44, 29)));
            EvaluationTable.Add("43h", new Evaluation(ToMinutes(42, 30), ToMinutes(43, 29)));
            EvaluationTable.Add("42h", new Evaluation(ToMinutes(41, 30), ToMinutes(42, 29)));
            EvaluationTable.Add("41h", new Evaluation(ToMinutes(40, 30), ToMinutes(41, 29)));
            EvaluationTable.Add("40h", new Evaluation(ToMinutes(39, 30), ToMinutes(40, 29)));
            EvaluationTable.Add("39h", new Evaluation(ToMinutes(38, 30), ToMinutes(39, 29)));
            EvaluationTable.Add("38h", new Evaluation(ToMinutes(37, 30), ToMinutes(38, 29)));
            EvaluationTable.Add("37a", new Evaluation(ToMinutes(36, 30), ToMinutes(37, 29)));
            EvaluationTable.Add("36a", new Evaluation(ToMinutes(35, 30), ToMinutes(36, 29)));
            EvaluationTable.Add("35a", new Evaluation(ToMinutes(34, 30), ToMinutes(35, 29)));
            EvaluationTable.Add("34a", new Evaluation(ToMinutes(33, 30), ToMinutes(34, 29)));
            EvaluationTable.Add("33a", new Evaluation(ToMinutes(32, 30), ToMinutes(33, 29)));
            EvaluationTable.Add("32a", new Evaluation(ToMinutes(31, 30), ToMinutes(32, 29)));
            EvaluationTable.Add("31a", new Evaluation(ToMinutes(30, 30), ToMinutes(31, 29)));
            EvaluationTable.Add("30a", new Evaluation(ToMinutes(29, 30), ToMinutes(30, 29)));
            EvaluationTable.Add("29a", new Evaluation(ToMinutes(28, 30), ToMinutes(29, 29)));
            EvaluationTable.Add("28a", new Evaluation(ToMinutes(27, 30), ToMinutes(28, 29)));
            EvaluationTable.Add("27a", new Evaluation(ToMinutes(26, 30), ToMinutes(27, 29)));
            EvaluationTable.Add("26a", new Evaluation(ToMinutes(25, 30), ToMinutes(26, 29)));
            EvaluationTable.Add("25a", new Evaluation(ToMinutes(24, 30), ToMinutes(25, 29)));
            EvaluationTable.Add("24a", new Evaluation(ToMinutes(23, 30), ToMinutes(24, 29)));
            EvaluationTable.Add("23a", new Evaluation(ToMinutes(22, 30), ToMinutes(23, 29)));
            EvaluationTable.Add("22a", new Evaluation(ToMinutes(21, 30), ToMinutes(22, 29)));
            EvaluationTable.Add("21a", new Evaluation(ToMinutes(20, 30), ToMinutes(21, 29)));
            EvaluationTable.Add("20a", new Evaluation(ToMinutes(19, 30), ToMinutes(20, 29)));
            EvaluationTable.Add("19a", new Evaluation(ToMinutes(18, 30), ToMinutes(19, 29)));
            EvaluationTable.Add("18a", new Evaluation(ToMinutes(17, 30), ToMinutes(18, 29)));
            EvaluationTable.Add("17a", new Evaluation(ToMinutes(16, 30), ToMinutes(17, 29)));
            EvaluationTable.Add("16a", new Evaluation(ToMinutes(15, 30), ToMinutes(16, 29)));
            EvaluationTable.Add("15a", new Evaluation(ToMinutes(14, 30), ToMinutes(15, 29)));
            EvaluationTable.Add("14a", new Evaluation(ToMinutes(13, 30), ToMinutes(14, 29)));
            EvaluationTable.Add("13a", new Evaluation(ToMinutes(12, 30), ToMinutes(13, 29)));
            EvaluationTable.Add("12a", new Evaluation(ToMinutes(11, 30), ToMinutes(12, 29)));
            EvaluationTable.Add("SCP", new Evaluation(ToMinutes(0, 0), ToMinutes(11, 29)));
        }

        public static float ToMinutes(int hours, int minutes)
        {
            return (hours * 60) + minutes;
        }

        public static String ToStringEvaluation(float minutes)
        {
            return String.Format("{0:00}:{1:00}", Math.Floor(minutes / 60.0f), minutes % 60.0f);
        }

        public static String Name(float minutes)
        {
            BuildEvaluationTable();
            foreach (var entry in EvaluationTable)
                if (entry.Value.Low <= minutes) return entry.Key;
            return "ERR";
        }

    }
}
