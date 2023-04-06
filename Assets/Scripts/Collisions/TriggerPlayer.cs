using Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions
{
    public class TriggerPlayer : MonoBehaviour
    {
        [SerializeField] private UnityEvent onTriggerWithPlayer = new();

        private void OnTriggerEnter(Collider other)
        {
            // extension method in ./Extensions/TagChecker.cs
            if (!other.IsPlayer()) return;
            
            onTriggerWithPlayer?.Invoke();
        }
    }
}