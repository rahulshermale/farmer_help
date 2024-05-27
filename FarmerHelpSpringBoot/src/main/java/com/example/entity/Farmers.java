package com.example.entity;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;

@Entity
public class Farmers {
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int fid;
	
	private String farmerName;
	private String city;
	
	@Column(unique = true)
	private Long moNO;
	@Column(unique = true)
	private String emailId;
	
	
//	@ManyToOne(fetch = FetchType.LAZY)
//  @JoinColumn(referencedColumnName = "id")
	 @ManyToOne
	 @JoinColumn(name = "market_id", nullable=false)	
	 @JsonIgnoreProperties("farmers")	
	 private Markets market;
	
	
	
	
	
	
	
	

}
