import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'SkiNet';

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
    this.http.get('http://localhost:5164/api/Products').subscribe((response: any) => {
      console.log(response);
    }, error => {
      console.log(error);
    });
  }

  //public forecasts?: WeatherForecast[];

  //constructor(http: HttpClient) {
  //  http.get<WeatherForecast[]>('/weatherforecast').subscribe(result => {
  //    this.forecasts = result;
  //  }, error => console.error(error));
  //}

  //ngOnInit(): void {

  //}

  //title = 'ECommAppClient';
}

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}
