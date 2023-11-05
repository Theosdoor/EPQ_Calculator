# EPQ Calculator

This is a calculator I made for my Extended Project Qualification (2020/21). A google drive folder containing my **full** submission can be found <a href="https://drive.google.com/drive/folders/17eVtX6k3sckr00V5xlsmQyD4ZomX0GNU?usp=drive_link" target="_blank">here</a>.

## I Background

This involved over 120 hours of independent research to design a calculator interface in Unity that was both functional and easy to use. I met regularly with my supervisor and maintained a production log throughout to keep my progress on track. After I was happy with my calculator following an iterative design process, I uploaded it online using WebGL so I could easy share it for testing and feedback which I could use to further improve my design. At the end of the project, I had to produce a 5000 word report and present my project to a board of examiners, clearly explaining what I had achieved and learned.

I used C# and the Unity 3D game engine (version 2019.4.1f1) to program and design the calculator. For version control I used SourceTree. My IDE for the project was Visual Studio.

## II How to use

![Screenshot of calculator](https://github.com/Theosdoor/EPQ_Calculator/blob/c7314bae3b8e1894356ba116e79ed16ebce2a30f/Calculator.png)

The calculator has 11 number buttons and 11 function buttons, plus an all-clear (AC) button. The +, -, ÷ and × work as would be expected on a generic calculator app. Click on the buttons to provide input (keyboard input is not supported!). To get use the special functions on the right hand side, you must input the number you wish to apply the function to first, and then press the function button. For example, to get cos(180 deg), inputting '180' then pressing 'cos' will give the expected answer of -1. Please note, pressing 'cos' before the desired function input number will apply the cosine function to whatever is in the display at the time. If there have been no prior inputs or the display has just been cleared, then this defaults to '0'.

Also note, if you press a number button twice then it will be treated as one float or integer, rather than two individual digits. I.e. pressing the '9' button twice, for example, is equal to ninety-nine, not two nines. 
