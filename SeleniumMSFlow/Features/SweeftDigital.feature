Feature: SweeftDigital
	Check SweeftDigital.com

@Desktop
Scenario: Check header navigaton
	Given Open SweeftDigital homepage
	When I click <button> on header navigation
	Then I am navigated to correct <page>
Examples: 
| button   | page     |
| Services | Services |