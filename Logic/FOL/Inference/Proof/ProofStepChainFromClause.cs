namespace AIMA.Core.Logic.FOL.Inference.Proof
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using AIMA.Core.Logic.FOL.KB.Data;
    using System.Collections.ObjectModel;

    /**
     * @author Ciaran O'Reilly
     * 
     */
    public class ProofStepChainFromClause : AbstractProofStep
    {
        private List<ProofStep> predecessors = new List<ProofStep>();
        private Chain chain = null;
        private Clause fromClause = null;

        public ProofStepChainFromClause(Chain chain, Clause fromClause)
        {
            this.chain = chain;
            this.fromClause = fromClause;
            this.predecessors.Add(fromClause.getProofStep());
        }

        //
        // START-ProofStep
        public override List<ProofStep> getPredecessorSteps()
        {
            return new ReadOnlyCollection<ProofStep>(predecessors).ToList<ProofStep>();
        }

        public override String getProof()
        {
            return chain.ToString();
        }

        public override String getJustification()
        {
            return "Chain from Clause: "
                    + fromClause.getProofStep().getStepNumber();
        }
        // END-ProofStep
        //
    }
}