export interface PlaneDTO {
  idZone: string, 
  idChecker: string,
  typeCheck: string,
  zoneName: string,
  idPlane: string,
  dateTimeStartGroup: string,
  dateTimeFinishGroup: string,
  badEquips: BadEquipsDTO[],
};

export interface BadEquipsDTO {
  rfId: string,
  name: string,
  dataExploitationBegin: string,
  dataExploitationFinish: string,
  equipmentInformation: string,
  planePlace: string,
  status: string,
};