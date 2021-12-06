using UnityEngine;

namespace CasinoRoyal
{
    public class Tape : MonoBehaviour
    {
        [SerializeField] private float speed = 0;
        public float Speed => speed;
        [SerializeField] private Rigidbody2D rb;
        public Rigidbody2D Rb => rb;

        private void Update()
        {
            rb.AddTorque(speed* Time.deltaTime , ForceMode2D.Impulse);
            if(speed > 0)
            {
                speed -= 1f;
            }
        }
        public void ClickPush(int value)
        {
            if (speed <= 0)
            {
                speed += value;
                rb.angularDrag = Random.Range(1f, 25f);
            }
        }
    }
}