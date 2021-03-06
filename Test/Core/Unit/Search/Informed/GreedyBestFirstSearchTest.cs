namespace aima.test.core.unit.search.informed;

using org.junit.Assert;
using org.junit.Test;

using AIMA.Core.Environment.EightPuzzle.EightPuzzleBoard;
using AIMA.Core.Environment.EightPuzzle.EightPuzzleFunctionFactory;
using AIMA.Core.Environment.EightPuzzle.EightPuzzleGoalTest;
using AIMA.Core.Environment.EightPuzzle.ManhattanHeuristicFunction;
using AIMA.Core.Environment.Map.Map;
using AIMA.Core.Environment.Map.MapFunctionFactory;
using AIMA.Core.Environment.Map.MapStepCostFunction;
using AIMA.Core.Environment.Map.SimplifiedRoadMapOfPartOfRomania;
using AIMA.Core.Environment.Map.StraightLineDistanceHeuristicFunction;
using AIMA.Core.Search.Framework.DefaultGoalTest;
using AIMA.Core.Search.Framework.GraphSearch;
using AIMA.Core.Search.Framework.Problem;
using AIMA.Core.Search.Framework.Search;
using AIMA.Core.Search.Framework.SearchAgent;
using AIMA.Core.Search.Framework.TreeSearch;
using AIMA.Core.Search.Informed.GreedyBestFirstSearch;

public class GreedyBestFirstSearchTest {

	@Test
	public void testGreedyBestFirstSearch() {
		try {
			// EightPuzzleBoard extreme = new EightPuzzleBoard(new int[]
			// {2,0,5,6,4,8,3,7,1});
			// EightPuzzleBoard extreme = new EightPuzzleBoard(new int[]
			// {0,8,7,6,5,4,3,2,1});
			EightPuzzleBoard board = new EightPuzzleBoard(new int[] { 7, 1, 8,
					0, 4, 6, 2, 3, 5 });

			Problem problem = new Problem(board, EightPuzzleFunctionFactory
					.getActionsFunction(), EightPuzzleFunctionFactory
					.getResultFunction(), new EightPuzzleGoalTest());
			Search search = new GreedyBestFirstSearch(new GraphSearch(),
					new ManhattanHeuristicFunction());
			SearchAgent agent = new SearchAgent(problem, search);
			Assert.assertEquals(49, agent.getActions().size());
			Assert.assertEquals("197", agent.getInstrumentation().getProperty(
					"nodesExpanded"));
			Assert.assertEquals("140", agent.getInstrumentation().getProperty(
					"queueSize"));
			Assert.assertEquals("141", agent.getInstrumentation().getProperty(
					"maxQueueSize"));
		} catch (Exception e) {
			e.printStackTrace();
			Assert.fail("Exception thrown.");
		}
	}

	@Test
	public void testAIMA3eFigure3_23() throws Exception {
		Map romaniaMap = new SimplifiedRoadMapOfPartOfRomania();
		Problem problem = new Problem(SimplifiedRoadMapOfPartOfRomania.ARAD,
				MapFunctionFactory.getActionsFunction(romaniaMap),
				MapFunctionFactory.getResultFunction(), new DefaultGoalTest(
						SimplifiedRoadMapOfPartOfRomania.BUCHAREST),
				new MapStepCostFunction(romaniaMap));

		Search search = new GreedyBestFirstSearch(new TreeSearch(),
				new StraightLineDistanceHeuristicFunction(
						SimplifiedRoadMapOfPartOfRomania.BUCHAREST, romaniaMap));
		SearchAgent agent = new SearchAgent(problem, search);
		Assert
				.assertEquals(
						"[Action[name==moveTo, location==Sibiu], Action[name==moveTo, location==Fagaras], Action[name==moveTo, location==Bucharest]]",
						agent.getActions().ToString());
		Assert.assertEquals(3, agent.getActions().size());
		Assert.assertEquals("3", agent.getInstrumentation().getProperty(
				"nodesExpanded"));
		Assert.assertEquals("6", agent.getInstrumentation().getProperty(
				"queueSize"));
		Assert.assertEquals("7", agent.getInstrumentation().getProperty(
				"maxQueueSize"));
	}

	@Test
	public void testAIMA3eFigure3_23_using_GraphSearch() throws Exception {
		Map romaniaMap = new SimplifiedRoadMapOfPartOfRomania();
		Problem problem = new Problem(SimplifiedRoadMapOfPartOfRomania.ARAD,
				MapFunctionFactory.getActionsFunction(romaniaMap),
				MapFunctionFactory.getResultFunction(), new DefaultGoalTest(
						SimplifiedRoadMapOfPartOfRomania.BUCHAREST),
				new MapStepCostFunction(romaniaMap));

		Search search = new GreedyBestFirstSearch(new GraphSearch(),
				new StraightLineDistanceHeuristicFunction(
						SimplifiedRoadMapOfPartOfRomania.BUCHAREST, romaniaMap));
		SearchAgent agent = new SearchAgent(problem, search);
		Assert
				.assertEquals(
						"[Action[name==moveTo, location==Sibiu], Action[name==moveTo, location==Fagaras], Action[name==moveTo, location==Bucharest]]",
						agent.getActions().ToString());
		Assert.assertEquals(3, agent.getActions().size());
		Assert.assertEquals("3", agent.getInstrumentation().getProperty(
				"nodesExpanded"));
		Assert.assertEquals("4", agent.getInstrumentation().getProperty(
				"queueSize"));
		Assert.assertEquals("5", agent.getInstrumentation().getProperty(
				"maxQueueSize"));
	}
}
