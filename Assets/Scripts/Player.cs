using UnityEngine;
using UnityEngine.UI;

namespace CasinoRoyal
{
    public class Player : SingletonBase<Player>
    {
        [SerializeField] private Tape modelTape;
        [SerializeField] private int speedPush;
        [SerializeField] private Button buttonPush;
        private bool active = false;
        public bool Active => active;
        private void Start()
        {
            active = false;
        }
        private void Update()
        {
            if (modelTape.Rb.angularVelocity != 0)
            {
                buttonPush.enabled = false;
                active = true;
            }
            else
            {
                buttonPush.enabled = true;
            }
        }
        public void Push()
        {
            modelTape.ClickPush(speedPush);
        }
        public void IsActive(bool activeRol)
        {
            active = activeRol;
        }
    }
}