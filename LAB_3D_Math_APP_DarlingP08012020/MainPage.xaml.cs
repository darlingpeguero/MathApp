using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409


//Class:          ERAU ISTA220 Programming Fundamentals
//Student:        Darling Peguero
//Instructor:     Christine E Lee, Instructor
//Date:           08/01/2020

/****************************************************************************************
 HomeWork Assignment: LAB 3D - C# - Math App

Revision:
            --Create a console, win form or uwp application that performs simple mathematics such as addition, multiplication, subtraction and division. 

            --The app will ask the user which type of mathematical action they would like or if they wish to exit, if the user inputs a mathematical 
              operator then ask the user  to provide 2 numbers; if the user inputs something other than a math operator the program writes to the screen 
             "Thanks for stopping by!" and exits. 

            --If the user asks for division and the second number is zero advise the user that division by zero is not a valid choice and ask them to 
              input a new number in place of zero.

            --Do the math and then output to the screen the first number added or multiplied or divided or subtracted by second number = answer. (a + b = c)

            --Define methods to perform the mathematical functions that get called within the app's Main function

Revision Date: 
                
Revised Date: 

Reference:https://github.com/Dbrauch8/Math-Assignment-with-Averages/blob/master/Ex2A_testScores/Program.cs

****************************************************************************************/
namespace LAB_3D_Math_APP_DarlingP08012020
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void exitBtn_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void calculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if ((bool)addition.IsChecked)
                {
                    add();
                }
                else if ((bool)subtraction.IsChecked)
                {
                    subtract();
                }
                else if ((bool)multiplication.IsChecked)
                {
                    multiply();
                }
                else if ((bool)division.IsChecked)
                {
                    divide();
                }
                else if ((bool)remainder.IsChecked)
                {
                    remainderValues();
                }
            }
            catch (DivideByZeroException)
            {
                answer.Text = "You are trying to devide by 0! Please try again.";
            }
            catch (FormatException)
            {
                answer.Text = "Thanks for stopping by!";
            }
        }

        private void add()
        {
            int left = int.Parse(leftinput.Text);
            int right = int.Parse(rightinput.Text);
            int outcome;
            outcome = left + right;
            answer.Text = $"{leftinput.Text} + {rightinput.Text} = {outcome}";
        }

        private void subtract()
        {
            int left = int.Parse(leftinput.Text);
            int right = int.Parse(rightinput.Text);
            int outcome;
            outcome = left - right;
            answer.Text = $"{leftinput.Text} - {rightinput.Text} = {outcome}";
        }

        private void multiply()
        {
            int left = int.Parse(leftinput.Text);
            int right = int.Parse(rightinput.Text);
            int outcome;
            outcome = left * right;
            answer.Text = $"{leftinput.Text} * {rightinput.Text} = {outcome}";
        }

        private void divide()
        {
            int left = int.Parse(leftinput.Text);
            int right = int.Parse(rightinput.Text);
            int outcome;
            outcome = left / right;
            answer.Text = $"{leftinput.Text} / {rightinput.Text} = {outcome}";
        }

        private void remainderValues()
        {
            float left = float.Parse(leftinput.Text);
            float right = float.Parse(rightinput.Text);
            float outcome; 
            outcome = left % right;
            answer.Text = $"{leftinput.Text} % {rightinput.Text} = {outcome}";
        }
    }
}
