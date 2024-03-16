package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.example.entity.Products;

import com.example.services.ProductServicesimpl;

@RestController
public class ProductController {

	@Autowired
	private ProductServicesimpl productservice;
	
	
	@GetMapping("api/product")
	public List<Products> getAllMarketList(){
	System.err.println(1);
	List<Products> list=productservice.getList();
		System.out.println(2);
		return list;
		
	}
	
	@GetMapping("api/product/{id}")
	public Optional<Products> getById(@PathVariable int id){
	
	return productservice.getMarketByid(id);

    }
	
	@PostMapping("api/product")
	public void addMarktes(@RequestBody Products v) {
		System.err.println(2);
		productservice.addMarket(v);
		
		
	}
}
