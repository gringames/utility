using UnityEngine;

namespace Basic
{
    public class Destroy : MonoBehaviour
    {
        // Start is called before the first frame update
        public void TriggerDestruction()
        {
            Destroy(gameObject);
        }
    }
}