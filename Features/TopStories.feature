Feature: TopStories
	In order to ensure that top stories are shown correctly
	As test engineer
	I want to validate that top stories are present on the page

Background:
	Given I have opened bbc.com/news web page

Scenario Outline: Presence of the Top Story
	When News page is opened
	Then the '<top story>' should be present

	Examples:
		| Top Story number | top story                                       |
		| Top Story #1     | //div[@data-entityid="container-top-stories#1"] |
		| Top Story #2     | //div[@data-entityid="container-top-stories#2"] |