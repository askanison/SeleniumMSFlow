@Mobile
Feature: MobileAviator
![MobileAviator](https://res.cloudinary.com/dpr7nvtku/image/upload/v1629644946/Adjarabet/MobileAviator_lyehxc.png)
Mobile Aviator page with slider and one play button


Scenario: Check Mobile Aviator as an authorized in user
	Given I have opened Adjarabet.com home page
	And I log in using 'sqatmaviator' and 'Paroli1#' credentials
	And I navigate to mobile 'Aviator' page
	When I clik Play Mobile Aviator button
	Then Mobile Aviator game is loaded


Scenario: Check Mobile Aviator as not authorized user
	Given I have opened Adjarabet.com home page
	And I navigate to mobile 'Aviator' page
	And I clik Play Mobile Aviator button
	When I log in using 'sqatmaviator' and 'Paroli1#' from opened login form
	Then Mobile Aviator game is loaded
