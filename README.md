## Boilerplate for step 10

Concepts to Cover: LINQ [Language Integrated Query] 

LINQTask1Test:
-------

TestCase1: TestToGetSelectedNameOfEmployee

       actual     : LINQTask1PropertyObject.SendSelectedNameofEmployee();
	   (string)
	   
	   expected   :Vikram
	   (string)
	   
TestCase2: TestToGetSelectedCourses

       actual     :LINQTask1PropertyObject.SendSelectedCourses();
	   (List<string>)
	   
	   
	   expected   : "Full Stack .Net", "Full Stack Java", "Full Stack Mean"
	   (List<string>)
	   

LINQTask2Test:
-------
TestCase3: TestToGetEmployeeIdsfromList

       actual     :LINQTask2PropertyObject.FunToSendSelectedEmployeeIds();
	   (int[])
	   
	   
	   expected   : {1,2,3}
	   (int [])	

LINQTask3Test:
-------
TestCase4: TestToGetEvenNumberOfValues

		actual     :LINQTask3PropertyObject.FunToReturnEvenNumberofItems();
	   (ArrayList)
	   
	   
	   expected   : {46,56}
	   (ArrayList)	

TestCase5: TestToGetOddNumberOfValues

		actual     :LINQTask3PropertyObject.FunToReturnOddNumberofItems();
	   (ArrayList)
	   
	   
	   expected   : {11,21,33,89,09,67}
	   (ArrayList)	
	   
TestCase6: TestToGetValueFromDelegate
        int valuefromTestcase = 2;
		actual     :LINQTask3PropertyObject.FuntoUseDelegatewithLambda(valuefromTestcase);
	   (int)
	   
	   
	   expected   : 4
	   (int)	
	   	   
TestCase7: TestToGetValueFromDelegatewithMorethnOneParameters
        int firstvalue = 10;
        int secondvalue = 15;
		actual     :LINQTask3PropertyObject.FuntoUseDelegatewithLambda(valuefromTestcase);
	   (int)
	   
	   
	   expected   : 25
	   (int)	
TestCase9: FuntoUseFuncDelegate
        int fisrstvaluetofuncdelegate = 10;
     
		actual     :LINQTask3PropertyObject.FuntoUseFuncDelegate(fisrstvaluetofuncdelegate);
	   (int)
	   
	   
	   expected   : 11
	   (int)	
TestCase10: TestToCheckfuncDelegatewithClassProperties
       
		actual     :LINQTask3PropertyObject.FuntoCheckfuncDelegatewithClassProperties();
	   (int)
	   
	   
	   expected   : 10
	   (int)	
TestCase11: TestToGetMaxValueofEmployeeId
      
		actual     :LINQTask3PropertyObject.FunToGetMaxValueofEmployeeId();
	   (int)
	   
	   
	   expected   : 4
	   (int)	
TestCase12: TestToGetMinValueofEmployeeId
      
		actual     :LINQTask3PropertyObject.FunToGetMinValueofEmployeeId();
	   (int)
	   
	   
	   expected   : 1
	   (int)		   
---

### To use this as a boilerplate for your new project, you can follow these steps

1. Clone the base boilerplate in the folder **exercise-10** of your local machine
     
    `git clone https://gitlab-cgi.stackroute.in/stack_csharp_bytelearning/exercise-10.git`

2. Navigate to exercise-9 folder

    `cd exercise-9`

3. Remove its remote or original reference

     `git remote rm origin`

4. Create a new repo in gitlab named `exercise-9` as private repo

5. Add your new repository reference as remote

     `git remote add origin https://gitlab-cgi.stackroute.in/{{yourusername}}/exercise-10.git`

     **Note: {{yourusername}} should be replaced by your username from gitlab**

5. Check the status of your repo 
     
     `git status`

6. Use the following command to update the index using the current content found in the working tree, to prepare the content staged for the next commit.

     `git add .`
 
7. Commit and Push the project to git

     `git commit -a -m "Initial commit | or place your comments according to your need"`

     `git push -u origin master`

8. Check on the git repo online, if the files have been pushed

### Important instructions for Participants
> - We expect you to write the assignment on your own by following through the guidelines, learning plan, and the practice exercises
> - The code must not be plagirized, the mentors will randomly pick the submissions and may ask you to explain the solution
> - The code must be properly indented, code structure maintained as per the boilerplate and properly commented
> - Follow through the problem statement shared with you

### MENTORS TO BEGIN REVIEW YOUR WORK ONLY AFTER ->
> - You add the respective Mentor as a Reporter/Master into your Assignment Repository
> - You have checked your Assignment on the Automated Evaluation Tool - Hobbes (Check for necessary steps in your Boilerplate - README.md file. ) and got the required score - Check with your mentor about the Score you must achieve before it is accepted for Manual Submission.
> - Intimate your Mentor on Slack and/or Send an Email to learner.support@stackroute.in - with your Git URL - Once you done working and is ready for final submission.

	   
**Note : Once you have cloned boilerplate from the given gitlab URL, open the project int Visual studio. 
Your project test cases might show compile time errors for methods, as you have not written the complete code.**
