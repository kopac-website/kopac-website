import { NgFor } from '@angular/common';
import { HttpClient } from '@angular/common/http';
import { Component, Inject, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-home',
  standalone: true,
  imports: [NgFor, RouterLink],
  templateUrl: './home.component.html',
  styleUrl: './home.component.css'
})
export class HomeComponent implements OnInit {
  public playersData: PlayersDTO[] = []; 

  constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string){}

  getPlayers(){
    return this.http.get<PlayersDTO[]>(this.baseUrl + "/players");
  }

  ngOnInit(): void {
    this.getPlayers().subscribe(result => {
      this.playersData = result;
    })
  }
}
export interface PlayersDTO{
  playerId: number;
  playerName: string;
  playerDescription: string;
  playerSkin: string;
  playerSocialNetwork1: string;
  playerSocialNetwork2: string;
  playerSocialNetwork3: string;
}