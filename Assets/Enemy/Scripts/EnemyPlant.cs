using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EnemySpace
{
    public class EnemyPlant : MonoBehaviour
    {
        [SerializeField] private Collision2D _collider2D;

        private void OnCollisionEnter2D(Collision2D other)
        {
            //if(_collider2D.collider)
            {
                Destroy(this.gameObject);
            }
            
        }
    }
}