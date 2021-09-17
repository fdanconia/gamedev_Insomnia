using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Platformer.Gameplay;
using static Platformer.Core.Simulation;
namespace Platformer.Mechanics
{
    public class EnemyStatic : MonoBehaviour
    {
        Rigidbody2D rb;
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }
        
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.name.Equals("Player"))
            {
                Schedule<PlayerEnteredDeathZone>();
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {

            if(collision.gameObject.name.Equals("Player"))
            {
                Schedule<PlayerEnteredDeathZone>();
            }
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }
}
