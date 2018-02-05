# watershed
Watershed is project for waterbudgeting and providing water policies and suggesting crops . In this we used wcf web service and asp.net mvc


WatershedService is WCF service on soap protocol for interoperability

watershed is mvc based website which consumes wcf service.

for Reusability we used class library .. In BOL we written business logic and DAL we written data connectivity logic
And BOM is our business Object Model which contain poco classes.




watersheddb is out Mysql Database.
we used ado.net with mysql 
and also used entity framework

watersheddb.sql file is for database


for security we used ssl also password are stored in encrypted form.


we performed manual unit testing using console project named testing.


Also provide functionality like sending mail for update password or forget password using smtpclient 
