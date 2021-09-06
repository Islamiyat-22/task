using System.Runtime.InteropServices;
using System.Reflection.Metadata;
using System.Net.Http.Headers;
using System.Collections.Concurrent;
using Microsoft.VisualBasic.CompilerServices;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Reflection.Emit;
using System.Data;
using System;

namespace GUESSING_GAME
{
    class Program
    {
        static void Main(string[] args)
        {
                int Level =0;
                var randomClass = new Random();

                Console.WriteLine("WELCOME TO THE NUMBER GUESSING GAME!!. ");
                Console.WriteLine("There are three levels in this game.");
                Console.WriteLine("EASY");
                Console.WriteLine("INTERMEDIATE");
                Console.WriteLine("HARD");

                Console.WriteLine("please pick a level to play");
                Level = int.Parse(Console.ReadLine());

                if(Level == 1)
                {
                    Console.WriteLine("easy");
                    int randomNum = randomClass.Next(1, 10);
                    int guessLeft = 6;

                    while (guessLeft > 0)
                    {
                        Console.WriteLine("Please enter a number ");
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == randomNum)
                        {
                            Console.WriteLine("You are Correct!!");
                            break;
                        }
                        else
                        {
                            guessLeft--;

                            if (guessLeft == 0)
                            {
                                Console.WriteLine($"sorry, {randomNum} was the correct number. ");
                            }
                        }

                    }
                
                        
                }
                else if(Level == 2)
                {
                    Console.WriteLine("intermediate");
                    int randomNum1 = randomClass.Next(1, 20);
                    int guessLeft1 = 4;

                    while (guessLeft1 > 0)
                    {
                        Console.WriteLine("Please enter a number ");
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == randomNum1)
                        {
                            Console.WriteLine("You are Correct!!");
                            break;
                        }
                        else
                        {
                            guessLeft1--;

                            if (guessLeft1 == 0)
                            {
                                Console.WriteLine($"sorry, {randomNum1} was the correct number. ");
                            }
                        }
                    }
                }
                else if(Level == 3)
                {
                    Console.WriteLine("hard");
                    int randomNum2 = randomClass.Next(1, 50);
                    int guessLeft2 = 3;

                    while (guessLeft2 > 0)
                    {
                        Console.WriteLine("Please enter a number ");
                        int guess = int.Parse(Console.ReadLine());

                        if (guess == randomNum2)
                        {
                            Console.WriteLine("You are Correct!!");
                            break;
                        }
                        else
                        {
                            guessLeft2--;

                            if (guessLeft2 == 0)
                            {
                                Console.WriteLine($"sorry, {randomNum2} was the correct number. ");
                            }
                        }
                    }
                }
                else
                {
                        Console.WriteLine("you have not chosen a level to play");
                }
        }

    }
}
