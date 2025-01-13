Name: Tanush Kumar
Date: 1/13/25
Project Name: All for One

Description:  
Design an API with for the endpoints:
Each endpoint must have their own Controller file, inside the Controller folder
Each one must have their own service file, inside a Service folder
You can use a model if the challenge can use it
This will include the following from prior mini challenges 
Hello World
Asking Questions
Adding Two Numbers
MadLib
Odd Or Even
Reverse It(Alphanumeric)
Reverse it (Numbers Only)
Magic 8 Ball
Guess It
Restaurant Picker

Peer review: Brock Spacek 

Comments: Checked Via Postman and Swagger! Overall you did a solid job with your code. I have a couple of things that I would recommend to help improve it. There are a few instances where you are using fixed int's on things like "Add Two Numbers" and "Odd or Even" instead of using TryParse for data validation. The two main things I found were that "Restaurant Picker" does not work. There is an extra input in Swagger that no matter what I input I am getting an invalid return. The other thing is that in "Guess It" I can guess outside of the range for the game i.e. range is 100 and I can guess 1000000 and it will just tell me it is higher. I suggest using an if statement to make sure the user doesn't go outside the range! Everything else is very smooth and works like you intended. A couple of tweaks and it will be great!
