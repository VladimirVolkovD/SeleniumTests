Feature: Calculator

Base template from SpecFLow calc example


@mytag
Scenario Outline: Add two numbers
	Given the first number is <FirstNumber>
	* the second number is  <SecondNumber>
	When the two numbers are added
	Then the result should be <Result>

Examples:
	| FirstNumber | SecondNumber | Result |
	| 50          | 70           | 120    |
	| 65          | 70           | 120    |
	| 87          | 25           | 65     |
	| 50          | 70           | 120    |
	| 45          | 95           | 140    |
	| 34          | 15           | 120    |
	| 76          | 11           | 66     |

Scenario Outline: Table
	Given the following users exist:
		| name   | email              | twitter         |
		| Aslak  | aslak@cucumber.io  | @aslak_hellesoy |
		| Julien | julien@cucumber.io | @jbpros         |
		| Matt   | matt@cucumber.io   | @mattwynne      |