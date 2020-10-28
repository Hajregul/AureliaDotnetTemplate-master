import { HttpClient } from "aurelia-fetch-client";
import { inject } from "aurelia-framework";

@inject(HttpClient)
export class Fetchdata {
	constructor(private http: HttpClient) { }
	messageShow: string;



	async activate() {
		await this.http.fetch("api/SampleData/HelloBetcom").then(result => result.json()).then(data => {
			this.messageShow = data;
			console.log(data);
		});
	}
}
