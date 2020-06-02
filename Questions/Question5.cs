using System;
using System.Collections.Generic;
using System.Linq;

namespace Questions
{
    public class Question5 : IQuestion
    {
        private void UpdateInPlace<T>(IList<T> arr, Func<T, T> func)
        {
            for (var i = 0; i < arr.Count; i++) arr[i] = func(arr[i]);
        }

        private int Increment(int x) => x + 1;

        private readonly Func<int, int> _incrementFunc;

        public Question5()
        {
            _incrementFunc = Increment;
        }
        
        private readonly int[] _arr = Enumerable.Range(0, 10).ToArray();
        
        // Does the following allocate per-call?
        public void Run()
        {
            UpdateInPlace(_arr, _incrementFunc);
        }
    }
}