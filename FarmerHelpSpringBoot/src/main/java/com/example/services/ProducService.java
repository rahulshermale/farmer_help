package com.example.services;

import java.util.List;
import java.util.Optional;

import com.example.entity.Products;


public interface ProducService {

	
	public List<Products> getList() ;
	
	public Optional<Products> getMarketByid(int id);
	
	public void addMarket(Products product) ;
}
