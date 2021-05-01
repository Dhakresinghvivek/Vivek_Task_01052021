using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BowlingBall.Tests
{
    [TestClass]
    public class GameFixture
    {
         /*Tavisca Starter Kits 
          Vivek Singh : Date 1st MAY 2021 
         */


        [TestMethod]
        public void Gutter_game_score_should_be_zero_test()
        {
            var game = new Game();
            Roll(game, 0, 20);
            Assert.AreEqual(0, game.GetScore());
        }

        private void Roll(Game game, int pins, int times)
        {
            for (int i = 0; i < times; i++)
            {
                game.Roll(pins);
            }
        }

        //
        [TestMethod]
        public void ZeroScore()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
                g.Roll(0);
            Assert.AreEqual(0, g.GetScore());
        }


        [TestMethod]
        public void CorrectSpareScore()
        {
            Game g = new Game();
            g.Roll(5);
            g.Roll(5);
            g.Roll(3);
            Assert.AreEqual(13, g.GetScore());
        }

        [TestMethod]
        public void CorrectStrikeScore()
        {
            Game g = new Game();
            g.Roll(10);
            g.Roll(5);
            g.Roll(6);
            Assert.AreEqual(21, g.GetScore());

        }

        [TestMethod]
        public void AllStrikes()
        {
            Game g = new Game();
            for (int i = 0; i < 10; i++)
            {
                g.Roll(10);

            }
            Assert.AreEqual(300, g.GetScore());
        }

        [TestMethod]
        public void AllOnes()
        {
            Game g = new Game();
            for (int i = 0; i < 20; i++)
            {
                g.Roll(1);

            }
            Assert.AreEqual(20, g.GetScore());
        }

        [TestMethod]
        public void AllNormals()
        {
            Game g = new Game();
            //Frame 1 
            g.Roll(3);
            g.Roll(3);
            //Frame 2
            g.Roll(3);
            g.Roll(3);
            //Frame 3
            g.Roll(4);
            g.Roll(4);
            //Frame 4 
            g.Roll(4);
            g.Roll(4);
            //Frame 5 
            g.Roll(5);
            g.Roll(5);
            //Frame 6 
            g.Roll(5);
            g.Roll(5);
            //Frame 7 
            g.Roll(6);
            g.Roll(6);
            //Frame 8 
            g.Roll(6);
            g.Roll(6);
            //Frame 9  
            g.Roll(7);
            g.Roll(7);
            //Frame 10 
            g.Roll(7);
            g.Roll(7);
            
            Assert.AreEqual(111, g.GetScore());
        }
    }
}
