using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MarsRover;

namespace MarsRoverTests
{
    [TestClass]
    public class MessageTests
    {
        //Message message1;
        //string testName;
        //Command[] commands = new Command[]
        //{ new Command(), new Command() };




        [TestMethod]
        public void ArgumentNullExceptionThrownIfNameNotPassedToConstructor()
        
            {
                try
                {
                    new Message("");
                }
                catch (ArgumentNullException ex)
                {
                    Assert.AreEqual("Command type required.", ex.Message);
                }
            }

        
        // create one command array-
        //fill the command array with ojects-

        //pass it into messaged constructor

        [TestMethod]
        public void ConstructorSetsCommandsField()
        {
            Message message1;
            string testName = "";

            Command[] commands1 = new Command[]
            { new Command("Go Foward", 5), new Command("Go backward",9) };

            message1 = new Message(testName, commands1);
            //testName = "This is touture";

           // Command[] commands1 = message1.Commands;
            //Message message1 = new Message(passAgrument);


            //Message newComman = new Message(commands[0], commands[0]);
            //Assert.AreEqual(newComman.Commands, "WEE" );
            //CollectionAssert.AreEqual(expected, actual);

            Assert.AreEqual(message1.Commands, typeof(Command[]));


            // foreach (Command item in message1.Commands )
            // {

            // }

            int index = 0;

            foreach (Command item in message1.Commands)
            {
                Assert.AreEqual(item.CommandType, 
                    commands1[index].CommandType);
            
            
                Assert.AreEqual(item.CommandType,
                    commands1[index].NewPosition);
                index++;
            }

        }

        [TestMethod]
        public void ConstructorSetsName()

        {
            Message newCommand = new Message("Erica");
            Assert.AreEqual(newCommand.Name, "Erica");

        }

        


    }
}
