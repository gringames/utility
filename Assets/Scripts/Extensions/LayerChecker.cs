using UnityEngine;

namespace Extensions
{
    public static class LayerChecker
    {
        public static bool IsInLayerMask(this Collider other, LayerMask layerMask)
        {
            return UniversalIsInLayerMask(other.gameObject, layerMask);
        }

        public static bool IsInLayerMask(this Collision other, LayerMask layerMask)
        {
            return UniversalIsInLayerMask(other.gameObject, layerMask);
        }


        private static bool UniversalIsInLayerMask(GameObject gameObject, LayerMask layerMask)
        {
            return (layerMask & (1 << gameObject.layer)) != 0;
        }
    }
}