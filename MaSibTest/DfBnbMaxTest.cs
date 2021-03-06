﻿using MaSib;
using MaSib.Domain.SIB;
using MaxSearchAlg;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace MaSibTest
{
    [TestClass]
    public class DfBnbMaxTest
    {
        //Public void MethodUnderTest_Scenario_ExpectedResult

        [TestMethod]
        public void Create_NewAStarSnake()
        {
            World w = new World(4,2);
            var heuristicFunc = new SnakeNoneHeuristic();
            Snake snake = new Snake(w, 0, heuristicFunc);
            DfBnbMax astar = new DfBnbMax(snake, new ImplicitGoal());
            Assert.IsNotNull(astar);
        }

        [TestMethod]
        public void Run_NewAStarSnake()
        {
            World w = new World(5, 3);
            var heuristicFunc = new SnakeNoneHeuristic();
            Snake snake = new Snake(w, 0, heuristicFunc);
            DfBnbMax dfBnbMax = new DfBnbMax(snake, new ImplicitGoal());
            dfBnbMax.Run(1);
            var maxGoal = dfBnbMax.GetMaxGoal();
            Assert.IsNotNull(maxGoal);
        }

        [TestMethod]
        public void Run_NewAStarBox()
        {
            World w = new World(5, 2,2);
            var heuristicFunc = new SnakeNoneHeuristic();
            int[] snakeHeads = new int[] { 0, 31 };
            BoxOD b = new BoxOD(w, snakeHeads,new BoxNoneHeuristic(), heuristicFunc);
            DfBnbMax dfBnbMax = new DfBnbMax(b, new ImplicitGoal());
            dfBnbMax.Run(1);
            var maxGoal = dfBnbMax.GetMaxGoal();
            Assert.IsNotNull(maxGoal);
        }

    }
}
