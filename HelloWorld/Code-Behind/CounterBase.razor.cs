using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor
{
    public class CounterBase : ComponentBase
    {
        public int currentCount = 0;

        public void IncrementCount()
        {
            currentCount++;
        }
    }
}