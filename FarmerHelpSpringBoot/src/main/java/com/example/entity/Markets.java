package com.example.entity;

import java.util.List;

import com.fasterxml.jackson.annotation.JsonIgnoreProperties;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.FetchType;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToMany;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;
import jakarta.persistence.UniqueConstraint;

@Entity
@Table(name = "Markets", uniqueConstraints = @UniqueConstraint(columnNames = "City"))
public class Markets {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column()
	private int mid;	
	private String marketName;
	private String City ;
	private String Address;
	private int contact;
	private String emailId;
	
	  @OneToMany(mappedBy = "market", cascade = CascadeType.ALL,fetch = FetchType.LAZY)
//	@JoinColumn(name="id", referencedColumnName = "id")
	 @JsonIgnoreProperties("market")	
	private List<Products> producte;
	

	  @OneToMany(mappedBy = "market", cascade = CascadeType.ALL,fetch = FetchType.LAZY)
//	@JoinColumn(name="id", referencedColumnName = "id")
	 @JsonIgnoreProperties("market")	
	private List<Farmers> farmers;
	

	  @OneToMany(mappedBy = "market", cascade = CascadeType.ALL,fetch = FetchType.LAZY)
//	@JoinColumn(name="id", referencedColumnName = "id")
	 @JsonIgnoreProperties("market")	
	private List<Buyer> buyers;

}
