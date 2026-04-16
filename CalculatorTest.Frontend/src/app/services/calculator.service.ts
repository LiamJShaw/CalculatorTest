import { Injectable, inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({ providedIn: 'root' })
export class CalculatorService {
  private readonly http = inject(HttpClient);
  private readonly baseUrl = 'http://localhost:5057/api/calculator';

  add(start: number, amount: number): Observable<number> {
    const params = new HttpParams()
      .set('start', start)
      .set('amount', amount);

    return this.http.get<number>(`${this.baseUrl}/add`, { params });
  }

  subtract(start: number, amount: number): Observable<number> {
    const params = new HttpParams()
      .set('start', start)
      .set('amount', amount);

    return this.http.get<number>(`${this.baseUrl}/subtract`, { params });
  }
}
