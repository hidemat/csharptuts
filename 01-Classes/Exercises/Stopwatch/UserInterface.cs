using System;

namespace Stopwatch
{
    public class UserInterface
    {
        private string _getUserInput()
        {
            Console.WriteLine("Please type: 'start', 'stop', or 'exit'");

            return Console.ReadLine();
        }

        public void StartLoop()
        {
            var proceed = true;
            var timer = new Timer();
            Console.WriteLine("Welcome to Stopwatch.\n");

            while (proceed)
            {
                switch (_getUserInput())
                {
                    case "start":
                        try {
                            timer.Start();
                            Console.WriteLine("Timer started.\n");
                        }
                        catch (InvalidOperationException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "stop":
                        timer.Stop();
                        Console.WriteLine("Timer stopped.\n");
                        Console.WriteLine("The time between start and stop was: {0}m : {1}s\n", timer.Duration.Minutes, timer.Duration.Seconds);
                        break;

                    case "exit":
                        timer.Stop();
                        proceed = false;
                        break;

                    default:
                        Console.WriteLine("Invalid command.\n");
                        break;

                }
            }
        }
    }
}