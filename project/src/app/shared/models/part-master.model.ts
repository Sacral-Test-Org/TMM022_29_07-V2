export class PartMasterModel {
  groupId: string;
  partNo: string;
  partStatus: string;
  partDesc: string;
  lineId: string;
  unitId: string;
  currentFormName: string;
  currentDate: Date;

  constructor(
    groupId: string,
    partNo: string,
    partStatus: string,
    partDesc: string,
    lineId: string,
    unitId: string,
    currentFormName: string,
    currentDate: Date
  ) {
    this.groupId = groupId;
    this.partNo = partNo;
    this.partStatus = partStatus;
    this.partDesc = partDesc;
    this.lineId = lineId;
    this.unitId = unitId;
    this.currentFormName = currentFormName;
    this.currentDate = currentDate;
  }
}