using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Bomb : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody m_rigidbody;
        [SerializeField]
        private ParticleSystem disappear;

        public bool isAffect { set; get; } = true;

        private void Awake()
        {
            if (m_rigidbody == null)
                m_rigidbody = GetComponent<Rigidbody>();
        }

        private void OnCollisionEnter(Collision other)
        {
            if (isAffect)
            {
                
                if (other.gameObject.layer == 7)
                {
                    GameObject.Instantiate(disappear, transform.position, transform.rotation);
                    Destroy(gameObject);
                }
            }
        }
    }
}
