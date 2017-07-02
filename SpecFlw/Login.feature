Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Login and Search
	Given I go to http://automationpractice.com/index.php
	And I search for shirt
	When I click search button
	Then the result page should show SEARCH Shirt
