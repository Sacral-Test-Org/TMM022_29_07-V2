using System;
using ProjectName.Api.Models;

namespace ProjectName.Api.DTOs
{
    public class PartMasterDTO
    {
        public string GroupId { get; set; }
        public string PartNo { get; set; }
        public string PartStatus { get; set; }
        public string PartDesc { get; set; }
        public string LineId { get; set; }
        public string UnitId { get; set; }
        public string CurrentFormName { get; set; }
        public DateTime CurrentDate { get; set; }

        public PartMasterDTO() { }

        public PartMasterDTO(PartMaster partMaster)
        {
            GroupId = partMaster.GroupId;
            PartNo = partMaster.PartNo;
            PartStatus = partMaster.PartStatus;
            PartDesc = partMaster.PartDesc;
            LineId = partMaster.LineId;
            UnitId = partMaster.UnitId;
            CurrentFormName = partMaster.CurrentFormName;
            CurrentDate = partMaster.CurrentDate;
        }

        public PartMaster ToModel()
        {
            return new PartMaster
            {
                GroupId = this.GroupId,
                PartNo = this.PartNo,
                PartStatus = this.PartStatus,
                PartDesc = this.PartDesc,
                LineId = this.LineId,
                UnitId = this.UnitId,
                CurrentFormName = this.CurrentFormName,
                CurrentDate = this.CurrentDate
            };
        }
    }
}