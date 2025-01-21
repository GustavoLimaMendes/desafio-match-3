using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Gazeus.DesafioMatch3
{
    public class SpawnParticles : MonoBehaviour
    {

        public GameObject effect01;

        public void SpawnVFXs(GameObject tile)
        {
            Debug.Log("BOOM");

            if (tile != null)
            {
                Instantiate(effect01, tile.transform.position , tile.transform.rotation);
            }

        }
    }
}
