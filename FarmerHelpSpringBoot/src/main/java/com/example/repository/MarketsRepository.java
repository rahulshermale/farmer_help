package com.example.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.entity.Markets;

@Repository
public interface MarketsRepository extends JpaRepository<Markets, Integer> {

	/*
	 * @Query("update Markets mk set mk.city=:city,mk.Address=:address")
	void updateMarket(@Param("city") String City,@Param("address") String Address,int id);


 */
	
}
