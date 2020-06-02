using System;

namespace Questions
{
    public class Question9 : IQuestion
    {
        [Flags]
        private enum CyclingElitenessFlags
        {
            LikesWearingLycraInPublic     =  0b00001,
            PaysForStravaPremium          =  0b00010,
            OwnsRaphaBrandedV60           =  0b00100,
            WeirdObsessionWithCarbonFibre =  0b01000,
            TalksEndlesslyAboutChainsets  =  0b10000
        }
        
        // Does the following allocate per-call?
        public void Run()
        {
            var keenBean =    CyclingElitenessFlags.TalksEndlesslyAboutChainsets 
                                            | CyclingElitenessFlags.LikesWearingLycraInPublic
                                            | CyclingElitenessFlags.PaysForStravaPremium;

            var isHipster = FlagHelper<CyclingElitenessFlags>.HasFlag(
                            keenBean, CyclingElitenessFlags.OwnsRaphaBrandedV60);
        }
    }
}