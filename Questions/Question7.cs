using System;
using System.Collections.Generic;
using System.Linq;

namespace Questions
{
    public class Question7 : IQuestion
    {
        private void UpdateInPlace<T>(IList<T> arr, Func<T, T> func)
        {
            for (var i = 0; i < arr.Count; i++) arr[i] = func(arr[i]);
        }

        private static int Increment(int x) => x + 1;
        
        private readonly int[] _arr = Enumerable.Range(0, 10).ToArray();
        
        // Does the following allocate per-call?
        public void Run()
        {
            UpdateInPlace(_arr, Increment);
        }
    }
}