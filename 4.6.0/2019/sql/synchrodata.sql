--数据同步sql



select  SUM(integral)  ,mem.id
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id

114	1
324	2
261	3
213	5
156	6
250	4
199	7
114	8
369	101
9776	102
123	13


UPDATE members ,(select  SUM(integral)  TotalIntegral,mem.id
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id)  temptotal

SET members.TotalIntegral =temptotal .TotalIntegral
WHERE members.Id=temptotal.id


---
UPDATE members
SET members.TotalIntegral =temptotal .TotalIntegral
FROM	 members ,(select  SUM(integral)  TotalIntegral,mem.id
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id)  temptotal
WHERE members.Id=temptotal.id
---

UPDATE members JOIN (select  SUM(integral)  TotalIntegral,mem.id
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id)  temptotal
		ON members.Id=temptotal.id
SET members.TotalIntegral =temptotal.TotalIntegral

---




select  SUM(integral)  ,mem.id,YEAR(integrals.CreatedTime) yearseg
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id,yearseg


1	1	2018	11
2	2	2018	47
3	3	2018	35
4	4	2018	5
5	3	2019	126
14	1	2019	15
15	7	2019	199
16	4	2019	130
17	6	2019	131
18	8	2019	114
19	5	2019	92
20	2	2019	172
21	101	2019	369
22	102	2019	9776
23	13	2019	123

UPDATE annualintegrals ,(select  SUM(integral) TotalIntegral ,mem.id,YEAR(integrals.CreatedTime) yearseg
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id,yearseg
)  temptotal

SET annualintegrals.AnnualIntegral =temptotal .TotalIntegral
WHERE annualintegrals.MemberId=temptotal.id
	AND annualintegrals.Years=temptotal.yearseg

1	1	2018	16
2	2	2018	47
3	3	2018	35
4	4	2018	5
5	3	2019	226
14	1	2019	98
15	7	2019	199
16	4	2019	250
17	6	2019	156
18	8	2019	114
19	5	2019	213
20	2	2019	277
21	101	2019	369
22	102	2019	9776
23	13	2019	123



---试验田
UPDATE annualintegrals ,(select  SUM(integral) TotalIntegral ,mem.id,YEAR(integrals.CreatedTime) yearseg
		FROM	 integrals ,members mem
		where  integrals.MemberId  =mem.id
GROUP BY mem.id,yearseg
)  temptotal

WHERE annualintegrals.AnnualIntegral =temptotal .TotalIntegral
 AND annualintegrals.MemberId=temptotal.id
	AND annualintegrals.Years=temptotal.yearseg
