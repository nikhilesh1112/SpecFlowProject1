Feature: Login_StepDefinitions

A short summary of the feature

@tag1
Scenario: Login invalid Deatils
Given open the browser
	When open the website page
	Then click on login page
	Then enter the invalid email id 'admin@microsoft.com'
	And enter the invalid password 'Pass@wor'


	@tag1
Scenario: Login Deatils
Given open the browser
	When open the website page
	Then click on login page
	Then  enter the email id 'admin@microsoft.com'
	And enter the password 'Pass@word1' 
	
