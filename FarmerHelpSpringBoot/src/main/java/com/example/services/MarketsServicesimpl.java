package com.example.services;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;

import com.example.entity.Markets;
import com.example.repository.MarketsRepository;

@Service
public class MarketsServicesimpl implements MarketService {
	@Autowired
	private MarketsRepository marketrepo;
	

	@Override
	public List<Markets> getList() {
		// TODO Auto-generated method stub
		return marketrepo.findAll();
	}

	@Override
	public Optional<Markets> getMarketByid(int id) {
		// TODO Auto-generated method stub
		return marketrepo.findById(id);
	}

	@Override
	public void addMarket(Markets mkr) {
		
		
		marketrepo.save(mkr);
		
		
	}

	@Override
	public void updateMarket(Markets mk,int id) {
		// TODO Auto-generated method stub
		
//		marketrepo.updateMarket(null, null, id);

		
	}




}
