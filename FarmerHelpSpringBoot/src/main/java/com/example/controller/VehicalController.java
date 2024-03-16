package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.example.entity.Markets;
import com.example.entity.Vehicals;
import com.example.services.MarketsServicesimpl;
import com.example.services.VehicalServicesimpl;

@RestController
public class VehicalController {
	
	@GetMapping("/api/vehical")
	public String myVehicls()
	{
		return "Hello";
		
		
	}
	
}
