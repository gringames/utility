using Extensions;
using UnityEngine;
using UnityEngine.Events;

namespace Collisions
{
    public class CollisionOverlap : MonoBehaviour
    {
        [SerializeField] private LayerMask layerMask;
        [SerializeField] private UnityEvent onCollision = new();

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.IsInLayerMask(layerMask))
            {
                onCollision?.Invoke();
            }
        }
    }
}
