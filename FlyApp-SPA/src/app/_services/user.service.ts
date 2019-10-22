import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from 'selenium-webdriver/http';

@Injectable({
    providedIn: 'root'
})
export class UserService {
    baseUrl = environment.apiUrl;

constructor(private http: HttpClient) {}
}
