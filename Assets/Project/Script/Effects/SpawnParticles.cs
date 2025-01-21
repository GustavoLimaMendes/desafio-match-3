using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

namespace Gazeus.DesafioMatch3
{
    public class SpawnParticles : MonoBehaviour
    {

        public RectTransform effect01;
        public RectTransform effect02;

        public void SpawnVFXs(GameObject tile)
        {
            
            if (tile != null)
            {
                Instantiate(effect01, tile.transform.position , tile.transform.rotation);
            }

        }

        public void SpawnVFXs2(GameObject tile)
        {

            if (tile != null)
            {
                Instantiate(effect02, tile.transform.position, tile.transform.rotation);
            }

        }
    }
}
