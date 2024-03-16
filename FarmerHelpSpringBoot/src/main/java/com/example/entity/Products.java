package com.example.entity;

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
	
	
	@ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(referencedColumnName = "id")
    private Markets market;
	
	public Products() {
		super();
		// TODO Auto-generated constructor stub
	}
	
	
	
	public Products(int pid, String product_name, String product_type, String product_Quality, int product_max_price,
			int product_low_price, int product_average_price, Markets market) {
		super();
		this.pid = pid;
		this.product_name = product_name;
		this.product_type = product_type;
		this.product_Quality = product_Quality;
		this.product_max_price = product_max_price;
		this.product_low_price = product_low_price;
		this.product_average_price = product_average_price;
		this.market = market;
	}



	public Markets getMarket() {
		return market;
	}



	public void setMarket(Markets market) {
		this.market = market;
	}



	public int getPid() {
		return pid;
	}
	public void setPid(int pid) {
		this.pid = pid;
	}
	public String getProduct_name() {
		return product_name;
	}
	public void setProduct_name(String product_name) {
		this.product_name = product_name;
	}
	public String getProduct_type() {
		return product_type;
	}
	public void setProduct_type(String product_type) {
		this.product_type = product_type;
	}
	public String getProduct_Quality() {
		return product_Quality;
	}
	public void setProduct_Quality(String product_Quality) {
		this.product_Quality = product_Quality;
	}
	public int getProduct_max_price() {
		return product_max_price;
	}
	public void setProduct_max_price(int product_max_price) {
		this.product_max_price = product_max_price;
	}
	public int getProduct_low_price() {
		return product_low_price;
	}
	public void setProduct_low_price(int product_low_price) {
		this.product_low_price = product_low_price;
	}
	public int getProduct_average_price() {
		return product_average_price;
	}
	public void setProduct_average_price(int product_average_price) {
		this.product_average_price = product_average_price;
	}
	
	
	
	
	
}
