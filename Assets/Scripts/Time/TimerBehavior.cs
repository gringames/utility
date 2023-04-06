using UnityEngine;
using UnityEngine.Events;

namespace Time
{
    public class TimerBehavior : MonoBehaviour
    {
        [SerializeField] private float duration = 1f;
        [SerializeField] private UnityEvent onTimerEnd = new();

        private TickableTimer _tickableTimer;

        private void Start()
        {
            _tickableTimer = new TickableTimer(duration);
            _tickableTimer.OnTimerEnd += HandleTickableTimerEnd;
        }

        private void HandleTickableTimerEnd()
        {
            onTimerEnd?.Invoke();
            Destroy(this);
        }

        void Update()
        {
            _tickableTimer.Tick(UnityEngine.Time.deltaTime);
        }
    }
}