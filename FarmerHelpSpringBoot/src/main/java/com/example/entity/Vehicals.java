package com.example.entity;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;

@Entity
public class Vehicals {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int vid;
	private String typeOfVehicale;
	private String nameOfVehical;
	private int vehicalNumber;
	public Vehicals() {
		super();
		// TODO Auto-generated constructor stub
	}
	public Vehicals(int vid, String typeOfVehicale, String nameOfVehical, int vehicalNumber) {
		super();
		this.vid = vid;
		this.typeOfVehicale = typeOfVehicale;
		this.nameOfVehical = nameOfVehical;
		this.vehicalNumber = vehicalNumber;
	}
	public int getVid() {
		return vid;
	}
	public void setVid(int vid) {
		this.vid = vid;
	}
	public String getTypeOfVehicale() {
		return typeOfVehicale;
	}
	public void setTypeOfVehicale(String typeOfVehicale) {
		this.typeOfVehicale = typeOfVehicale;
	}
	public String getNameOfVehical() {
		return nameOfVehical;
	}
	public void setNameOfVehical(String nameOfVehical) {
		this.nameOfVehical = nameOfVehical;
	}
	public int getVehicalNumber() {
		return vehicalNumber;
	}
	public void setVehicalNumber(int vehicalNumber) {
		this.vehicalNumber = vehicalNumber;
	}
	
	
}
