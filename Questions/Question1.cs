using System.Collections.Generic;

namespace Questions
{
    public class Question1 : IQuestion
    {
        private IEnumerable<int> MakeRange(int n)
        {
            for (var i = 0; i < n; i++)
            {
                yield return i;
            }
        }
        
        // Does the following allocate per-call?
        public void Run()
        {
            var q = MakeRange(100);
        }
    }
}