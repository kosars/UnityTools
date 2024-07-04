using UnityEngine;

namespace kosars.UnityExtensions
{
    public static class RigidbodyExtensions
    {
        public static void ChangeDirection(this Rigidbody rb, Vector3 direction) {
            rb.linearVelocity = direction.normalized * rb.linearVelocity.magnitude;
        }

        public static void NormalizeVelocity(this Rigidbody rb, float magnitude = 1) {
            rb.linearVelocity = rb.linearVelocity.normalized * magnitude;
        }
    }
}