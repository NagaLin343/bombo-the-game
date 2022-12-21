using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public class StoneSpawner : MonoBehaviour
	{
		[SerializeField]
		private GameObject[] stonePrefabs;
		[SerializeField]
		private ParticleSystem appear;

		public GameObject Spawn()
		{
			var position = transform.position;
			var rotation = transform.rotation;
			var index = Random.Range(0, stonePrefabs.Length);
			appear.Play();
			return GameObject.Instantiate(stonePrefabs[index], position, rotation);
		}
	}
}
