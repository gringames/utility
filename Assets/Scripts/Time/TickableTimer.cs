using System;

namespace Time
{
    public class TickableTimer
    {
        public float RemainingSeconds { get; private set; }
        public event Action OnTimerEnd;

        public TickableTimer(float duration)
        {
            RemainingSeconds = duration;
        }

        public void Tick(float deltaTime)
        {
            if (RemainingSeconds == 0) return;

            RemainingSeconds -= deltaTime;

            CheckForTimerEnd();
        }

        private void CheckForTimerEnd()
        {
            if (RemainingSeconds > 0) return;

            RemainingSeconds = 0;

            OnTimerEnd?.Invoke();
        }
    }
}