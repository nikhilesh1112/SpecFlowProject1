Feature: Login_StepDefinitions

A short summary of the feature

@tag1
Scenario: Login invalid Deatils
Given open the browser
	When open the website page
	Then click on login page
	When Enter Credentials
	| Key         | Value                  |
	| username    | admin123@microsoft.com |
	| password    | Pass@word            |
	Then Invalid login


	@tag1
Scenario: Login Deatils
Given open the browser
	When open the website page
	Then click on login page
	When Enter Credentials
	| Key         | Value                  |
	| username    | admin@microsoft.com |
	| password    | Pass@word1             |
	Then Successfull login

	
