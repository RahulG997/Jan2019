use sqlday4

create database sqlday4

Create Table Agent
(
	AgentID INT AUTO_INCREMENT,
	FirstName varchar(30), 
   MI varchar(1),
   LastName varchar(30),
   FullName varchar(80),
   Gender varchar(10),
    Dob TIMESTAMP,
    SSN varchar(30),
    MaritalStatus varchar(30),
    Address1 varchar(30),
    Address2 varchar(30),
    City varchar(30),
    State varchar(30),
    ZipCode varchar(30),
    Country varchar(30),
    Primary Key(AgentID)
  )
  select * from agent
  
  insert into agent(FirstName,MI,LastName,Gender,DOB,SSN,MaritalStatus,Address1,Address2,City,STATE,ZipCode,Country)
  values('bhuvana','m','m','female','1997-04-03','4558-4552-4145','single','no-23','adaiyar','chennai','tamilnadu','641005','india'),
  ('raja','m','j','male','1997-02-12','4558-45552-4145','single','no-93','murugannagar','madurai','tamilnadu','644567','india'),
  ('jai','a','b','male','1997-04-07','9558-4552-4145','single','no-23','sathy','coimbatore','tamilnadu','641076','india'),
  ('maddy','g','m','male','1998-03-07','4958-4552-4145','single','no-87','sathy','coimbatore','tamilnadu','641067','india'),
  ('karthi','v','r','male','1998-04-08','4568-4552-4145','single','no-43A','ooty','coimbatore','tamilnadu','641009','india'),
  ('dharun','m','k','male','1997-07-10','4558-4992-4145','single','no-3','ramnager','thirupur','tamilnadu','641054','india'),
  ('karthik','r','g','male','1997-08-07','4998-4552-4145','single','no-54C','sirumugai','coimbarore','tamilnadu','631005','india'),
  ('apu','m','m','female','1997-09-07','4988-4552-4145','married','no-13','karamadai','coimbatore','tamilnadu','641305','india'),
  ('yash','h','a','female','1997-01-12','4558-4902-4145','married','no-21','raja street','coimbatore','tamilnadu','641835','india'),
  ('anto','b','c','female','1997-06-08','4558-4552-8145','married','no-83','aravind nagar','pondicherry','tamilnadu','641085','india'),
  ('amala','m','k','female','1997-04-06','4558-4552-4995','single','no-90','ramnagar','chennai','tamilnadu','641003','india')
  
drop table agent


Create Table Policy
(
  PolicyID int AUTO_INCREMENT,
  AppNumber varchar(30),
  AppDate date,
  PolicyNumber varchar(30),
  AnnualPremium numeric(9,2),
  PaymentModeID int CHECK(PaymentModeID IN(1,2,3)),
  ModalPremium numeric(9,2),
  constraint pk_policy_policyID primary key(PolicyID)
);


INSERT INTO POLICY(APPNUMBER,APPDATE,POLICYNUMBER,ANNUALPREMIUM,PAYMENTMODEID,MODALPREMIUM)
VALUES('A001','2010-1-12','C001',12000,2,2000),
('A002','2010-12-12','C002',20000,1,12000),
('A003','2010-12-12','C003',150000,1,20000),
('A004','2005-01-02','P001',22000,1,1000),
('A005','2009-09-03','S231',122000,2,22000),
('A006','2010-02-12','A131',232000,2,21000),
('A007','2007-09-11','P231',212000,2,23000),
('A008','2009-11-12','S231',122000,2,22000),
('A009','2009-10-10','I231',192000,1,24000)	



create table AgentPolicy
(
   AgentID INT,
   PolicyID INT,
   IsSplitAgent INT,
   constraint fk_agentpolicy_agentid foreign key(agentid) 
   REFERENCES Agent(AgentID) on delete cascade,
	constraint fk_agentpolicy_policyid foreign key(policyid)
	REFERENCES policy(policyID) on delete cascade,
   constraint pk_agp primary Key(AgentID,PolicyID)
)

drop table agentpolicy

select * from agentpolicy

delete from agent where agentid=1


INSERT INTO AGENTPOLICY(AGENTID,POLICYID,IsSplitAgent)
VALUES(1,1,2),
					(1,3,1),
					(2,3,1),
					(2,1,1),
					(2,4,1),
					(2,5,1),
					(4,1,2),
					(4,3,1),
					(5,1,2),
					(5,2,1)
