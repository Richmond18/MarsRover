using System;
using System.Collections.Generic;
using System.Linq;
using MarsRover;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MarsRoverTests
{
    [TestClass]
    public class RoverTests
    {

        [TestMethod]
        public void ConstructorSetsDefaultPosition()
        {
            Rover newCommand = new Rover(9);
            Assert.AreEqual(newCommand.Position, 9);
        }


        [TestMethod]
        public void ConstructorSetsDefaultMode()
        {
            Rover newCommand = new Rover(9);
            Assert.AreEqual(newCommand.Mode, "NORMAL");
        }


        [TestMethod]
        public void ConstructorSetsDefaultGeneratorWatts()
        {
            Rover newCommand = new Rover(9);
            Assert.AreEqual(newCommand.GeneratorWatts, 110);
        }
        // the test should check that when a rover object receives a message.
        //contains a “MODE_CHANGE” command, that rover’s Mode field is updated.
        //The rover has two modes that can be passed as values to a mode change command, “LOW_POWER” and “NORMAL”

        [TestMethod]
        public void RespondsCorrectlyToModeChangeCommand()
        {
            Command[] commands = {
                 new Command("MOVE", 5000),
                 new Command("MOVE", 6000),
                 new Command("MOVE", 10000)
             };

            Message newMessage = new Message("Test message with one command", commands);

            Rover newRover = new Rover(98382);


            newRover.ReceiveMessage(newMessage);

            Assert.AreEqual(newRover.Position, commands[2].NewPosition);


            // RecieveMessage should iterate over an array of Commands
            // Pull out each Position and set Rover.Position to its value
            // I can handle that by .....
        }

        [TestMethod]

        public void DoesNotMoveInLowPower()
        {

            {
                Command[] commands = {
                 new Command("LOWER POWER", 5000),
                 new Command("MOVE", "LOWER POWER MODE"),
                 new Command("MOVE", 10000)
             };

                Command test1 = new Command("Move", "LOWER POWER MODE");
                Assert.AreEqual(test1.NewMode, commands[1].NewMode);
                
               






                // Message newMessage = new Message("Test message with one command", commands);

                //Rover newRover = new Rover(98382);


                //newRover.ReceiveMessage(newMessage);

                // Assert.AreEqual(newRover.Position, commands[2].NewPosition);



            }


           

        }


        [TestMethod]

        public void PositionChangesFromMoveCommand()
        {

        }

    }
}

