using System;
using UnityEngine;

namespace CasinoRoyal
{
    public class Index : MonoBehaviour
    {
        [SerializeField] private int score;
        public int Score => score;

        private void OnTriggerEnter2D(Collider2D collision)
        {
           score = Int32.Parse(collision.name);
        }
    }
}