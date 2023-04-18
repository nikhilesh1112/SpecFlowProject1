Feature: Checkout_Payment


Login to web page

@tag1 
Scenario: click on login
	Given open the browser
	When open the website page
	Then click on login page  
	When Enter Credentials
	| Key         | Value                  |
	| username    | admin@microsoft.com |
	| password    | Pass@word1             |
	Then Successfull login 
	Then searching items
	Then AddToCart
	
	

	
	   
	
		