export interface PlaneDTO {
  idZone: string, 
  idChecker: string,
  type: string,
  zoneName: string,
  planeId: string,
  dataBegin: string,
  dataEnd: string,
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