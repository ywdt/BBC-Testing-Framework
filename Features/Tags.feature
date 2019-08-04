Feature: Tags
	In order to ensure that tags are shown correctly
	As a test engineer
	I want to validate the search results with the corresponding tags

Background:
	Given I have opened the bbc.com/news web page

Scenario: Top story tag search validation
	When I copy the tag from the top story
	And I paste that tag into the search field
	When I click on the search
	Then the first search result should match

Scenario Outline: Validation of the search results
	When I have entered '<Tag>' as search keyword
	And I press the search button
	Then the '<First Search Result>' should correspond with the Tag

	Examples:
		| Tag         | First Search Result |
		| UK Politics | Politics            |
		| UK          | UK News             |
		| Europe      | Europe              |
		| US & Canada | US & Canada         |
		| Asia        | Asia                |
		| China       | China               |