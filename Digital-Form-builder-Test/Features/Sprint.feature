Feature: Digital form regression -Sprint

Background:
	Given Navigate to Home page

@sprint


#Scenario Outline: 001-Add Data Import Component
#	Given User is on Dashboard Page
#	#Then verify Digital Form Builder title
#	Then Verify Start Now link
#	Then click on Start Now link
#	Then User Select the form "<FormName>"
#	Then User click on 'Edit form' in my form
#	Then Click on create component
#	#Then Verify 'Data Import' component
#	#Then Verify component label 'Allows user to upload datasets from their local machine and store it on the database'
#	Then Click on on the 'Data Import' Component
#	Then Enter Title 'Data Import Title Component'
#	Then User click on button 'Import a new document'
#	Then Enter Title 'DataDocument' in import document
#	Then Upload the file 'Dataset examplesUKPRN test'
#	Then select 'DataDocument' document in Data import
#	Then User Select ColumnName and ColumnType
#		| Name                        | Type      | Maxdays_Past | Maxdays_Future | Maxlength | Min | Max      | Precision |
#		| UKPRN                       | Number    |              |                |           | 1   | 99999999 |           |
#		| Institution_Name_Legal_Name | Text      |              |                | 50        |     |          |           |
#		| UK_Address                  | UKAddress |              |                |           |     |          |           |
#		| DateField                   | Date      | 2585         | 2595           |           |     |          |           |
#	Then Make component is optional
#	Then Click on save button
#	Then Click on preview button
#	Then Verify 'First page' in page
#	Then Click on 'Continue' Button
#	Then Upload backup file 'Dataset examplesUKPRN test.csv'
#	Then Validate the file and messages
#	Then Click on 'Continue' Button
#	Then Verify 'Summary' in page
#	Then Verify 'Submit' Button
#	Then Click on 'Submit' button
#	Then Verify 'Submission complete' in page
#	Then close the runner window
#Examples:
#	| FormName        |
#	| automationtest1 |


@Regression1 @demo
Scenario Outline: 002-Edit Data Import Component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then User click on Edit component
	Then Enter Title 'Edited'
	Then Click on save button
	Then Click on preview button
	Then Verify 'First page' in page
	Then Click on 'Continue' Button
	Then Verify Edited component name 'Data Import Title ComponentEdited' in page
	Then Click on 'Continue' Button
	Then Verify 'Summary' in page
	Then Verify 'Submit' Button
	Then Click on 'Submit' button
	Then Verify 'Submission complete' in page
	Then Verify 'What happens next'
	Then close the runner window


Examples:
	| FormName        |
	| automationtest1 |


@Sprint2_1 @demo
Scenario Outline: 003-Delete Data Import Component
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then clean the component


Examples:
	| FormName        |
	| automationtest1 |


#Story :123950	
@Sprint2_6 @demo
Scenario Outline: 001-Verify Add Condition button(123950)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Verify condition button in form

Examples:
	| FormName        |
	| automationtest1 |

#Story :123950
@Sprint2_6 @demo
Scenario Outline: 002-Verify Add or edit condition(123950)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Verify condition button in form
	Then Click on Condition button and verify Add or edit condition

Examples:
	| FormName        |
	| automationtest1 |

#Story :123950	
@Sprint2_6 @demo
Scenario Outline: 003-Verify Add condition value(123950)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Condition button and verify Add or edit condition
	Then Add condition value "<DisplayName>","<Componentname>","<condition>","<value>"
Examples:
	| FormName        | DisplayName | Componentname    | condition | value |
	| automationtest1 | Condition   | Number Component | is        | 12    |

#Story :123950
@Sprint2_6 @demo
Scenario Outline: 004-Verify Add condition value(123950)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Condition button and verify Add or edit condition
	Then verify "<DisplayName>" in condition
Examples:
	| FormName        | DisplayName |
	| automationtest1 | Condition   |

   #Story :123950
@Sprint2_6 @demo
Scenario Outline: 005-Delete condition(123950)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then User click on 'Edit form' in my form
	Then Click on Condition button and verify Add or edit condition
	Then Delete "<DisplayName>" in condition


Examples:
	| FormName        | DisplayName |
	| automationtest1 | Condition   |


@Sprint2_6
Scenario Outline: 006 Verify form name (127116)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then Click on create new form
	Then Enter the form name 'Automationtest122'
	Then Click on Next button
	Then Verify label 'First page'
	Then Verify label 'Second page'
	Then Verify label 'Summary'
	Then go to Dashboard
	Then User Select the form "<FormName>"
	Then Verify "<FormName>" formname
Examples:
	| FormName          |
	| Automationtest122 |


	##DSI component to be shown in the summary page (134509)
	##rounding up value 
	## accept 0 values
	

@Sprint3_6
Scenario Outline: DSI component to be shown in the summary page (134509)
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then verify Digital Form Builder title
	Then Click on create new form
	Then Enter the form name 'Automationtest1'
	Then Click on Next button
	Then Verify label 'First page'
	Then Verify label 'Second page'
	Then Verify label 'Summary'
	Then go to Dashboard
	Then User Select the form "<FormName>"
	Then Verify "<FormName>" formname
Examples:
	| FormName          |
	| Automationtest122 |



@sprint8.1
Scenario Outline: 009_ntp
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Click on start now
	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
	Then verify Organization  "<Org>" and "<FormName>" in your detail page
	Then Click on start Now if its displayed
	Then Click on Save and continue
	Then Check the page "<PageName>"
	Then Check the URL "<URL>"
	Then Click on Signout Button
	Then close the runner window

Examples:
	| FormName                                                     | DFEUserName                 | Password | DFESignin | Org      | PageName                                             | URL                                                                                |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+1@gmail.com  | Password | UKPRN     | 10078001 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+2@gmail.com  | Password | UKPRN     | 10078002 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+3@gmail.com  | Password | UKPRN     | 10078003 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+4@gmail.com  | Password | UKPRN     | 10078004 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+5@gmail.com  | Password | UKPRN     | 10078005 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+6@gmail.com  | Password | UKPRN     | 10078006 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+7@gmail.com  | Password | UKPRN     | 10078007 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+8@gmail.com  | Password | UKPRN     | 10078008 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+9@gmail.com  | Password | UKPRN     | 10078009 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+10@gmail.com | Password | UKPRN     | 10078010 | National Tutoring Programme service for schools      | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-service-for-schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+11@gmail.com | Password | UKPRN     | 10078011 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+12@gmail.com | Password | UKPRN     | 10078012 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+13@gmail.com | Password | UKPRN     | 10078013 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+14@gmail.com | Password | UKPRN     | 10078014 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+15@gmail.com | Password | UKPRN     | 10078015 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+16@gmail.com | Password | UKPRN     | 10078016 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+17@gmail.com | Password | UKPRN     | 10078017 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+18@gmail.com | Password | UKPRN     | 10078018 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+19@gmail.com | Password | UKPRN     | 10078019 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+20@gmail.com | Password | UKPRN     | 10078020 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+21@gmail.com | Password | UKPRN     | 10078021 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+22@gmail.com | Password | UKPRN     | 10078022 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+23@gmail.com | Password | UKPRN     | 10078023 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+24@gmail.com | Password | UKPRN     | 10078024 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+25@gmail.com | Password | UKPRN     | 10078025 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+26@gmail.com | Password | UKPRN     | 10078026 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+27@gmail.com | Password | UKPRN     | 10078027 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+28@gmail.com | Password | UKPRN     | 10078028 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+29@gmail.com | Password | UKPRN     | 10078029 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+30@gmail.com | Password | UKPRN     | 10078030 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/School-NTP-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+31@gmail.com | Password | UKPRN     | 10078031 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+32@gmail.com | Password | UKPRN     | 10078032 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+33@gmail.com | Password | UKPRN     | 10078033 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+34@gmail.com | Password | UKPRN     | 10078034 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+35@gmail.com | Password | UKPRN     | 10078035 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+36@gmail.com | Password | UKPRN     | 10078036 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+37@gmail.com | Password | UKPRN     | 10078037 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+38@gmail.com | Password | UKPRN     | 10078038 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+39@gmail.com | Password | UKPRN     | 10078039 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+40@gmail.com | Password | UKPRN     | 10078040 | National Tutoring Programme for schools              | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/NTP-school-service      |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+41@gmail.com | Password | UKPRN     | 10078041 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+42@gmail.com | Password | UKPRN     | 10000568 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+43@gmail.com | Password | UKPRN     | 10078043 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+44@gmail.com | Password | UKPRN     | 10078044 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+45@gmail.com | Password | UKPRN     | 10078045 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+46@gmail.com | Password | UKPRN     | 10078046 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+47@gmail.com | Password | UKPRN     | 10008074 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+48@gmail.com | Password | UKPRN     | 10078048 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+49@gmail.com | Password | UKPRN     | 10078049 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+50@gmail.com | Password | UKPRN     | 10078050 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule             |



@sprint8.2
Scenario Outline: 010_ntp independent special schools journey
	Given User is on Dashboard Page
	Then verify Digital Form Builder title
	Then Verify Start Now link
	Then click on Start Now link
	Then User Select the form "<FormName>"
	Then Click on test link in dashboard in "<FormName>"
	Then Click on start now
	Then Enter "<DFEUserName>" and "<Password>" and select the "<DFESignin>" in "<Org>"
	Then verify Organization  "<Org>" and "<FormName>" in your detail page
	Then Click on start Now if its displayed
	Then Click on Save and continue
	Then Check the page "<PageName>"
	Then Check the URL "<URL>"
	And I click on independent special schools subform link
	And I enter all the details of "<No of Schools>" schools
	And I Submit the form with given details
	Then Click on Signout Button
	Then close the runner window
Examples:
	| FormName                                                     | DFEUserName                 | Password | DFESignin | Org      | PageName                                             | URL                                                                    | No of Schools |
	| P_Submit your National Tutoring Programme year-end statement | digitalforms01+41@gmail.com | Password | UKPRN     | 10078041 | NTP year-end statement service for local authorities | https://uat.test.digital-forms.education.gov.uk/qwn3_m7h9t/LA-schedule | 50            |

	
