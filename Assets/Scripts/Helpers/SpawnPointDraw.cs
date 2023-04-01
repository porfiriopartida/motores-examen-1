using UnityEngine;

namespace Helpers
{
    public class SpawnPointDraw : MonoBehaviour
    {
        public Float spawnPointRadiusGizmo;
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(transform.position, spawnPointRadiusGizmo.Value);
        }
    }
}
