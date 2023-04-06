using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace Time
{
    public class CoroutineTimer : MonoBehaviour
    {
        [SerializeField] private float duration;
        [SerializeField] private bool endTimerOnDestroy;
        [SerializeField] private UnityEvent onTimerEnd = new();

        private void Start()
        {
            StartCoroutine(StartTimer());
        }

        private void OnDestroy()
        {
            if (endTimerOnDestroy)
            {
               EndNow();
            }
        }

        public void EndNow()
        {
            onTimerEnd?.Invoke();
            StopAllCoroutines(); // for safety, so that timer won't do stuff even after it has been destroyed
        }

        private IEnumerator StartTimer()
        {
            yield return new WaitForSeconds(duration);
            EndNow();
        }
    }
}