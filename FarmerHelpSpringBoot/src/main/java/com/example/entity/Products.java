package com.example.entity;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import jakarta.persistence.Entity;
import jakarta.persistence.FetchType;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;

@Entity
public class Products {

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int pid;
	private String product_name;
	private String product_type;
	private String product_Quality;
	private int product_max_price;
	private int product_low_price;
	private int product_average_price;
	
	
//	@ManyToOne(fetch = FetchType.LAZY)
//    @JoinColumn(referencedColumnName = "id")
	 @ManyToOne
	 @JoinColumn(name = "market_id", nullable=false)	
	 @JsonIgnoreProperties("producte")	
    private Markets market;
	
	
	 
	 @ManyToOne
	 @JoinColumn(name = "buyer_id", nullable=false)	
	 @JsonIgnoreProperties("producte")	
	 private Buyer buyer;
	 
	 
	 
	 
	
	
	
}
