package com.example.entity;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import jakarta.annotation.Generated;
import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.FetchType;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;

@Entity
public class Buyer {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private int bid;
	private String buyerName;
	private String buyerEmail;
	private int moNo;
	
	
	 @ManyToOne
	 @JoinColumn(name = "market_id", nullable=false)	
	 @JsonIgnoreProperties("buyers")	
    private Markets market;
	 

	  @OneToMany(mappedBy = "buyer", cascade = CascadeType.ALL,fetch = FetchType.LAZY)
//	@JoinColumn(name="id", referencedColumnName = "id")
	 @JsonIgnoreProperties("market")	
	private List<Products> products;


}
