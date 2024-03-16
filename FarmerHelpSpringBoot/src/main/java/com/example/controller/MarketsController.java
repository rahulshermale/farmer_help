 package com.example.controller;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.entity.Markets;
import com.example.services.MarketsServicesimpl;

import jakarta.annotation.PostConstruct;



@RestController
@CrossOrigin("*")
public class MarketsController {
	
	@Autowired
	private MarketsServicesimpl marketservice;
	
	
	@GetMapping(value = "api/market")
	public List<Markets> getAllMarketList(){
	
	List<Markets> listmarkets=marketservice.getList();
		
		return listmarkets;
		
	}
	
	@GetMapping("api/market/{id}")
	public Optional<Markets> getById(@PathVariable int id){
	
	return marketservice.getMarketByid(id);

    }
	
	@PostMapping("api/market")
	public void addMarktes(@RequestBody Markets mkr) {
		
		marketservice.addMarket(mkr);
		
		//return ResponseEntity.ok("Data Saved");
		
	}
	
}
