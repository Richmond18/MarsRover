using System;
namespace MarsRover
{
    public class Message
    {
        public string Name { get; set; }
        public Command[] Commands { get; set; }

        public Message(string name, Command[] commands)
        {
            //Command[] command = { new Command("", ""), new Command("", 0) };
           // Message newMessage = new Message("Test message with two commands", commands);

            this.Name = name;
            this.Commands = commands;
        }
        public Message(string name)
        {
            this.Name = name;
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(name, "Command type required.");
            }
        }

      

    }
}
