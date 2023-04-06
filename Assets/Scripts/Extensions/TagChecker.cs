using UnityEngine;

namespace Extensions
{
    public static class TagChecker
    {
        public static bool IsPlayer(this Collider other)
        {
            return other.CompareTag("Player");
        }
        
        public static bool IsPlayer(this Collision collision)
        {
            return collision.gameObject.CompareTag("Player");
        }
    }
}