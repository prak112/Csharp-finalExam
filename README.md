# Course Exam
## Tasks
1. Build logic for acceptable format of phone number from user input in Main()
2. Build method to create username from user input (firstname, lastname) in Main() as Static Method
3. Build class "Javelin Throw" with following properties :
	- id (int)
	- athleteName (string)
	- meters (int/double)
	- centimeters (int/double)

## Task 1
- The following criteria must be implemented :
	- length of 13 characters
	- starts with +358
	- verifiy if all characters are numbers within range of 0-9
	- application notifies whether entered number is acceptable or not


## Task 2
- The following criteria must be implemented :
	- accept user input (firstname, lastname)
	- USERNAME = first 3 letters of firstname + first 5 letters of lastname
	- example :
	```
	firstname = "Lumi"
	lastname = "Ukkonen"
	username = "UkkonLum"
	```


## Task 3
- Create Classes in following categories :
	- JavelinThrow :
		- Properties:
			- id (int)
			- name (string)
			- throwDistance_inMeters (double)
			- throwDistance_inCentimeters (double)

	- Product :
		- Properties :
			- id (int)
			- name (string)
			- price (decimal)
		- Methods :
			- CalculateDiscountedPrice(deci)
		