using System;
using System.ComponentModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace IlliaTeliuk_PZPI212_CourseWortk_InterpolBase
{   [Serializable]
    public class Gangstar
    {
        
        public string? name { get; set; }
        public string? secondName { get; set; }
        public string? fatherName { get; set; }
        public string? nickname { get; set; }
        public string? growth { get; set; }
        public string? hairColor { get; set; }
        public string? eyesColor { get; set; }
        public string? specialSigns { get; set; }
        public string? nationality { get; set; }
        public string? dateBirth { get; set; }
        public string? gang { get; set; }
        public string? roleInGang { get; set; }
        public string? crime { get; set; }
    }
}
