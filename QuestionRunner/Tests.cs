using System;
using Questions;
using NUnit.Framework;

namespace QuestionRunner
{
    [TestFixture]
    public class Tests
    {
        private static int GCDiff(Action a, int nIters)
        {
            static int TotalGCCount()
                =>   GC.CollectionCount(0) 
                   + GC.CollectionCount(1) 
                   + GC.CollectionCount(2);

            var gcBefore = TotalGCCount();

            for (var i = 0; i < nIters; i++) a();

            var gcAfter = TotalGCCount();

            return gcAfter - gcBefore;
        }

        private static bool TestForAllocation(IQuestion question) => GCDiff(question.Run, 10_000_000) > 0;
        
        [Test]
        public void RunQuestion1() { TestContext.WriteLine($"{nameof(Question1)} Allocated: {TestForAllocation(new Question1())}"); }
        
        [Test]
        public void RunQuestion2() { TestContext.WriteLine($"{nameof(Question2)} Allocated: {TestForAllocation(new Question2())}"); }
        
        [Test]
        public void RunQuestion3() { TestContext.WriteLine($"{nameof(Question3)} Allocated: {TestForAllocation(new Question3())}"); }
        
        [Test]
        public void RunQuestion4() { TestContext.WriteLine($"{nameof(Question4)} Allocated: {TestForAllocation(new Question4())}"); }
        
        [Test]
        public void RunQuestion5() { TestContext.WriteLine($"{nameof(Question5)} Allocated: {TestForAllocation(new Question5())}"); }
        
        [Test]
        public void RunQuestion6() { TestContext.WriteLine($"{nameof(Question6)} Allocated: {TestForAllocation(new Question6())}"); }
        
        [Test]
        public void RunQuestion7() { TestContext.WriteLine($"{nameof(Question7)} Allocated: {TestForAllocation(new Question7())}"); }
        
        [Test]
        public void RunQuestion8() { TestContext.WriteLine($"{nameof(Question8)} Allocated: {TestForAllocation(new Question8())}"); }
        
        [Test]
        public void RunQuestion9() { TestContext.WriteLine($"{nameof(Question9)} Allocated: {TestForAllocation(new Question9())}"); }
    }
}