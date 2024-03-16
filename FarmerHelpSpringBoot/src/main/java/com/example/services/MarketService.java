package com.example.services;

import java.util.List;
import java.util.Optional;

import com.example.entity.Markets;
import com.example.repository.MarketsRepository;

public interface MarketService {

	
	
	
	public List<Markets> getList();
	public Optional<Markets> getMarketByid(int id);
	//public void addMarket(Markets mk);

//	public void addMarket(List<Markets> mkr);
//	public void updateMarket(int id);
	void updateMarket(Markets mk, int id);
	void addMarket(Markets mkr);
	
}
