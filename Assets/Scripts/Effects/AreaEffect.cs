using UnityEngine;

namespace Effects
{
    public class AreaEffect : MonoBehaviour
    {
        [SerializeField] private float effectRadius = 10f;

        public void TriggerEffect()
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, effectRadius);

            foreach (var collider in colliders)
            {
                // TODO: do effect
                Debug.Log("affected " + collider.name);
            }
        }
    }
}