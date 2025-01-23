using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Gazeus.DesafioMatch3.Models;

namespace Gazeus.DesafioMatch3
{
    public class SpawnParticles : MonoBehaviour
    {

        [SerializeField] RectTransform[] effect01;
        [SerializeField] RectTransform[] effect02;

        public void SpawnVFXs(GameObject pos, TileType tileType )
        {

            if (pos != null)
            {
                Instantiate(effect01[((int)tileType)], pos.transform.position, pos.transform.rotation);          
            }               

        }

        public void SpawnVFXs2(GameObject pos, TileType tileType)
        {

            if (pos != null)
                Instantiate(effect02[((int)tileType)], pos.transform.position , pos.transform.rotation);

        }
    }
}
