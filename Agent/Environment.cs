namespace AIMA.Core.Agent
{
    using System;
    using System.Collections.Generic;
    /**
     * An abstract description of possible discrete Environments in which Agent(s) 
     * can perceive and act.
     */

    /**
     * @author Ravi Mohan
     * @author Ciaran O'Reilly
     */
    public interface Environment
    {
        /**
         * 
         * @return The Agents belonging to this Environment.
         */
        List<IAgent> getAgents();

        /**
         * Add an agent to the Environment.
         * 
         * @param agent
         *            the agent to be added.
         */
        void addAgent(IAgent agent);

        /**
         * Remove an agent from the environment.
         * 
         * @param agent
         *            the agent to be removed.
         */
        void removeAgent(IAgent agent);

        /**
         * 
         * @return the EnvironmentObjects that exist in this Environment.
         */
        List<EnvironmentObject> getEnvironmentObjects();

        /**
         * Add an EnvironmentObject to the Environment.
         * 
         * @param eo
         *            the EnvironmentObject to be added.
         */
        void addEnvironmentObject(EnvironmentObject eo);

        /**
         * Remove an EnvironmentObject from the Environment.
         * 
         * @param eo
         *            the EnvironmentObject to be removed.
         */
        void removeEnvironmentObject(EnvironmentObject eo);

        /**
         * Move the Environment one time step forward.
         */
        void step();

        /**
         * Move the Environment n time steps forward.
         * 
         * @param n
         *            the number of time steps to move the Environment forward.
         */
        void step(int n);

        /**
         * Step through time steps until the Environment has no more tasks.
         */
        void stepUntilDone();

        /**
         * 
         * @return if the Environment is finished with its current task(s).
         */
        bool isDone();

        /**
         * Retrieve the performance measure associated with an Agent.
         * 
         * @param forAgent
         *            the Agent for which a performance measure is to be retrieved.
         * @return the performance measure associated with the Agent.
         */
        double getPerformanceMeasure(IAgent forAgent);

        /**
         * Add a view on the Environment.
         * 
         * @param ev
         *            the EnvironmentView to be added.
         */
        void addEnvironmentView(EnvironmentView ev);

        /**
         * Remove a view on the Environment.
         * 
         * @param ev
         *            the EnvironmentView to be removed.
         */
        void removeEnvironmentView(EnvironmentView ev);

        /**
         * Notify all registered EnvironmentViews of a message.
         * 
         * @param msg
         *            the message to notify the registered EnvironmentViews with.
         */
        void notifyViews(String msg);
    }
}