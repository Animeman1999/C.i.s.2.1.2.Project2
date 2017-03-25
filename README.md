# Cis212Project2
Jeffrey Martin

# CRUD operation methods in each class. These classes fit the definition of "Class 1" per the instruction sheet.

Class AllContactRelatedTables

Get - FetchSingleContactInclusiveData
Create - AddNewContact
Update - UpdateContactInformation
Delete - DeleteContact

Class CompaniesAndEmployeesTables
Get - FetchBrowseDataSet
Get - FetchLastNameDataSet
Get - FetchCompanyNameDataSet
Get - CheckIfCompanyInDatabase

Class EmployeesTable
Get - CreateCount

# OLE Command funtions and method in the DataBaseFetcher class. This class fits the definiton of "Class 2" per the instruction sheets.

return Data Set - getOleDataSet
return Data Reader - getOleDataReader
return Scaler (integer)- IntegerScalarOleDbCommand 
return true/false - ObjectFoundOleDbCommand

method used for create, update, delete - CreateOleDbCommand


Program is pretty intuitve to functoin. Browse the list or seach by company name or last name.  Click on a item in the list to see more detailed information.  The detailed information can be eddited or deleted.  You can add a new company to the list and finnaly you can find out the total number of contacts in the list.

#No, know errors.