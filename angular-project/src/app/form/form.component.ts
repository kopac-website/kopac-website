import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, Inject } from '@angular/core';
import { FormControl, FormGroup, FormsModule, ReactiveFormsModule, Validators } from '@angular/forms';

@Component({
  selector: 'app-form',
  standalone: true,
  imports: [ReactiveFormsModule, FormsModule],
  templateUrl: './form.component.html',
  styleUrl: './form.component.css'
})
export class FormComponent {

  constructor(@Inject('BASE_URL') private baseUrl: string, private http: HttpClient){}

  formGroup = new FormGroup ({
    mc_nickname: new FormControl('', Validators.required),
    dc_tag: new FormControl('', Validators.required),
    reason: new FormControl('', Validators.required)
  });

  onSubmit(){
    if(this.formGroup.valid){
      this.createForm(this.formGroup.value.mc_nickname, this.formGroup.value.dc_tag, this.formGroup.value.reason).subscribe();
    }
  }

  createForm(mc_nickname: string, dc_tag: string, reason: string){
    const url =  `${this.baseUrl}/form/create-form`;
    const headers = new HttpHeaders({'Content-type': 'application/json'});
    return this.http.put(url, {Mc_Nickname: mc_nickname, Dc_Tag: dc_tag, Reason: reason}, { headers });
  }
}
