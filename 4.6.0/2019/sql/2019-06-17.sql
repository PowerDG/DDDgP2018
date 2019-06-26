SELECT members.Name,members.Photo,appraisals.Type,appraisals.Level ,appraisals.`Year`
FROM members,appraisals
                            WHERE members.Id=appraisals.MemberId AND Members.IsLeave = 0  
AND appraisals.Type='年中'
--   AND appraisals.Year=2018
-- 

SELECT Id,Name,Photo,TotalIntegral,IFNULL(MemberAnnualIntegrals.AnnualIntegral,0) AnnualIntegral
                            FROM Members
                            LEFT JOIN(
	                          SELECT MemberId,AnnualIntegral FROM AnnualIntegrals
                              WHERE Years = DATE_FORMAT(NOW(),'%Y')
                            ) AS MemberAnnualIntegrals
                            ON Members.Id = MemberAnnualIntegrals.MemberId
                            WHERE Members.IsLeave = 0
                            ORDER BY TotalIntegral DESC
SELECT * FROM medals WHERE  IsDiscard = 0 ORDER BY CreatedTime DESC


SELECT * FROM Medals WHERE Id=14

     SELECT members.Name,members.Photo,appraisals.Type,appraisals.Level FROM members,appraisals
                            WHERE members.Id=appraisals.MemberId AND Members.IsLeave = 0 AND appraisals.Type='年末'
                                  AND appraisals.Year=2018 
ORDER BY appraisals.TotalScore

