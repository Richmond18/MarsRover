using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)

        {


            //Console.WriteLine("Hello World!");
            //Rover myRover = new Rover(20);
            //Console.WriteLine(myRover.ToString());
            //Command newCommand1 = ;
            //Command newCommand2 = ;

            Command[] commands = {
                 new Command("MOVE", 5000), // index 0
                 new Command("JUMP", 10000), // index 1
             };


            Message newMessage = new Message("Test message with one command", commands);


            //Console.WriteLine(newMessage.Commands.Length);
            //Console.WriteLine(newMessage.Commands[0].NewPosition);


            Rover newRover = new Rover(98382);

            Console.WriteLine(newRover.ToString());

            newRover.ReceiveMessage(newMessage);


            Console.WriteLine(newRover.ToString());


        }
    }
}
