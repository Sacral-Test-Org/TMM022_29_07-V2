using System;

namespace ProjectName.Api.Models
{
    public class PartMaster
    {
        public int GroupId { get; set; }
        public string PartNo { get; set; }
        public string PartStatus { get; set; }
        public string PartDesc { get; set; }
        public int LineId { get; set; }
        public int UnitId { get; set; }
        public string CurrentFormName { get; set; }
        public DateTime CurrentDate { get; set; }
    }
}