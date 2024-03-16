package com.example.entity;

import java.util.List;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Column;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;
import jakarta.persistence.UniqueConstraint;

@Entity
@Table(name = "Markets", uniqueConstraints = @UniqueConstraint(columnNames = "City"))
public class Markets {
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	@Column()
	private int id;
	
	private String City ;
	private String Address;
	
	@OneToMany( cascade = CascadeType.ALL)
	@JoinColumn(name="id", referencedColumnName = "id")
	private List<Products> producte;

	public Markets() {
		super();
		// TODO Auto-generated constructor stub
	}

	public Markets(int id, String city, String address, List<Products> producte) {
		super();
		this.id = id;
		City = city;
		Address = address;
		this.producte = producte;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getCity() {
		return City;
	}

	public void setCity(String city) {
		City = city;
	}

	public String getAddress() {
		return Address;
	}

	public void setAddress(String address) {
		Address = address;
	}

	public List<Products> getProducte() {
		return producte;
	}

	public void setProducte(List<Products> producte) {
		this.producte = producte;
	}
	
	
	
	
	

}
