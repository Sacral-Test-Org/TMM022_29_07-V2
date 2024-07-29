import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { PartMasterModel } from '../../shared/models/part-master.model';

@Injectable({
  providedIn: 'root'
})
export class PartMasterService {
  private apiUrl = 'http://your-api-url.com'; // Replace with your actual API URL

  constructor(private http: HttpClient) {}

  getCurrentDate(): Observable<string> {
    // For now, we generate the date locally
    const currentDate = new Date().toISOString().split('T')[0];
    return of(currentDate);
  }

  getPartMasterData(): Observable<PartMasterModel> {
    // Mock data for now, replace with actual API call
    const partMasterData: PartMasterModel = {
      groupId: '',
      partNo: '',
      partStatus: '',
      partDesc: '',
      lineId: '',
      unitId: '',
      currentFormName: 'PART_MASTER',
      currentDate: new Date().toISOString().split('T')[0]
    };
    return of(partMasterData);
  }
}
