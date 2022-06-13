using IndianStateCensusAnalyzer.POCO;

namespace IndianStateCensusAnalyzer
{
    internal class CensusDTO
    {
        private POCO.StateCodeDAO stateCodeDAO;
        private CensusDataDAO censusDataDAO;

        public CensusDTO(POCO.StateCodeDAO stateCodeDAO)
        {
            this.stateCodeDAO=stateCodeDAO;
        }

        public CensusDTO(CensusDataDAO censusDataDAO)
        {
            this.censusDataDAO=censusDataDAO;
        }
    }
}