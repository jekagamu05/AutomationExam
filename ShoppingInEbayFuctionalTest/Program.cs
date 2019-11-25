using NUnit.Framework;
using ShoppingInEbayLog.Core.Extensions;
using ShoppingInEbayLog.Core.Selenium;
using System;
using System.IO;
using static ShoppingInEbayLog.Core.Common.Enums;

namespace ShoppingInEbay.FunctionalTesting
{

    public class Program
    {
         
     public static void Main()
        {
            try
            {
                ShowMessage("Automation Exam", MessageType.Default);
                ShowMessage("This is a project for execute a Automated Test into a url, Do you like start? [y][n] Default [y]", MessageType.Info);
                string answer = Console.ReadLine();
                if (answer.Equals("y") || string.IsNullOrEmpty(answer))
                {
                    StartUp selenium = new StartUp(ShowMessage);
                    string targetPath =  "AutomatedTest";
                    selenium.Init(targetPath);
                   // Assert.That(new FileInfo("TestResults"), Does.Exist);
                }
                else
                {
                    ShowMessage("you not like continue the Unit Test", MessageType.Danger);
                }

                Console.ReadLine();

            }
            catch (Exception e)
            {
                ShowMessage(e.GetAllMessages(), MessageType.Danger);
            }
        }

        public static void ShowMessage(string pMessage, MessageType pTypeMessage)
        {
            switch (pTypeMessage)
            {
                case MessageType.Success:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case MessageType.Info:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case MessageType.Warning:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case MessageType.Danger:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case MessageType.Default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
            }
            Console.WriteLine(pMessage);
            Console.ForegroundColor = ConsoleColor.White;
        }


    }
}
