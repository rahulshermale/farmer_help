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
	
}
