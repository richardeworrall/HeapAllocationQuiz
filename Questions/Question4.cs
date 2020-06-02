using System;
using System.Collections.Generic;
using System.Linq;

namespace Questions
{
    public class Question4 : IQuestion
    {
        private void UpdateInPlace<T>(IList<T> arr, Func<T, T> func)
        {
            for (var i = 0; i < arr.Count; i++) arr[i] = func(arr[i]);
        }

        private readonly int[] _arr = Enumerable.Range(0, 10).ToArray();
        
        // Does the following allocate per-call?
        public void Run()
        {
            var q = 8;
            
            UpdateInPlace(_arr, x => q + x + 1);
        }
    }
}