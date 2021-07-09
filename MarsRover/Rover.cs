using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public void ReceiveMessage(Message message)
        {
            for (int i = 0; i < message.Commands.Length; i++)
            {
                this.Position = message.Commands[i].NewPosition;
            }

        }

        public void DoesnotMove(Command commanding)
        {
            for (int i = 0; i < commanding.NewMode.Length;)
            {
                if (commanding.NewMode == "LOWER POWER MODE")
                {
                    this.Position = this.Position;
                }
            }
        }

        public Rover()
        { }

        public Rover(int position)
        {
            this.Position = position;
            this.Mode = "NORMAL";
            this.GeneratorWatts = 100;

            //if (this.Mode == "LOWER")

            //{
            //    throw new ArgumentException(this.Mode, "Rover cannot move");
            //}
        }


        public override string ToString()
        {
            return $"Position: {this.Position} | Mode: {this.Mode} | GeneratorWatts: {this.GeneratorWatts}";
        }
    }

}
