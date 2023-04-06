using Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions
{
    public class TriggerOverlapLayer : MonoBehaviour
    {
        [SerializeField] private LayerMask layerMask;
        [SerializeField] private UnityEvent onTrigger = new();

        private void OnTriggerEnter(Collider other)
        {
            if (other.IsInLayerMask(layerMask))
            {
                onTrigger?.Invoke();
            }
        }
    }
}