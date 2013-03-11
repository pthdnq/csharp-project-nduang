INSERT INTO account
VALUES ('quang','quang','quang123',1,1)




UPDATE account
SET Pass = 'quang1234'
WHERE Username ='quang'


DELETE FROM account
WHERE Username='quang' and Pass= 'quang1234'

SELECT COUNT(*) FROM account

SELECT COUNT(*) FROM account
where Online= 1

  SELECT COUNT(*)as tongsooffline FROM account
where Online= 0

select Username as taikhoan,Function_Level as chucvu from account
inner join Level
on Level.ID_Level=account.Level


SELECT * FROM Pho
WHERE Ten_pho LIKE 'H%'

