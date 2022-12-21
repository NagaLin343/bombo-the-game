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
                    StartCoroutine(DestroyBomb());
                }
            }
        }
        public IEnumerator DestroyBomb()
        {
            var time = 0;
            while (time <= 1)
            {
                time += 1;
                //yield return null;
                yield return new WaitForSeconds(.2f);
                Debug.Log("this");
            }
            GameObject.Instantiate(disappear, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
