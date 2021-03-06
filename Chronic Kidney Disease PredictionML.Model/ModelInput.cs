// This file was auto-generated by ML.NET Model Builder. 

using Microsoft.ML.Data;

namespace Chronic_Kidney_Disease_PredictionML.Model
{
    public class ModelInput
    {
        [ColumnName("age"), LoadColumn(0)]
        public float Age { get; set; }


        [ColumnName("bp"), LoadColumn(1)]
        public float Bp { get; set; }


        [ColumnName("sg"), LoadColumn(2)]
        public float Sg { get; set; }


        [ColumnName("al"), LoadColumn(3)]
        public float Al { get; set; }


        [ColumnName("su"), LoadColumn(4)]
        public float Su { get; set; }


        [ColumnName("rbc"), LoadColumn(5)]
        public string Rbc { get; set; }


        [ColumnName("pc"), LoadColumn(6)]
        public string Pc { get; set; }


        [ColumnName("pcc"), LoadColumn(7)]
        public string Pcc { get; set; }


        [ColumnName("ba"), LoadColumn(8)]
        public string Ba { get; set; }


        [ColumnName("bgr"), LoadColumn(9)]
        public float Bgr { get; set; }


        [ColumnName("bu"), LoadColumn(10)]
        public float Bu { get; set; }


        [ColumnName("sc"), LoadColumn(11)]
        public float Sc { get; set; }


        [ColumnName("sod"), LoadColumn(12)]
        public float Sod { get; set; }


        [ColumnName("pot"), LoadColumn(13)]
        public float Pot { get; set; }


        [ColumnName("hemo"), LoadColumn(14)]
        public float Hemo { get; set; }


        [ColumnName("pcv"), LoadColumn(15)]
        public string Pcv { get; set; }


        [ColumnName("wbcc"), LoadColumn(16)]
        public string Wbcc { get; set; }


        [ColumnName("rbcc"), LoadColumn(17)]
        public float Rbcc { get; set; }


        [ColumnName("htn"), LoadColumn(18)]
        public bool Htn { get; set; }


        [ColumnName("dm"), LoadColumn(19)]
        public bool Dm { get; set; }


        [ColumnName("cad"), LoadColumn(20)]
        public bool Cad { get; set; }


        [ColumnName("appet"), LoadColumn(21)]
        public string Appet { get; set; }


        [ColumnName("pe"), LoadColumn(22)]
        public bool Pe { get; set; }


        [ColumnName("ane"), LoadColumn(23)]
        public bool Ane { get; set; }


        [ColumnName("class"), LoadColumn(24)]
        public bool Class { get; set; }


    }
}
