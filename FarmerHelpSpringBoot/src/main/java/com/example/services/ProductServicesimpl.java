package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.entity.Products;
import com.example.repository.ProductRepository;


@Service
public class ProductServicesimpl implements ProducService{

	@Autowired
	private ProductRepository productrepo;
	
	public List<Products> getList() {
		System.out.println(3);
		// TODO Auto-generated method stub
		return productrepo.findAll();
	}

	public Optional<Products> getMarketByid(int id) {
		// TODO Auto-generated method stub
		return productrepo.findById(id);
	}

	public void addMarket(Products products) {
		// TODO Auto-generated method stub
		productrepo.save(products);
	}

}
