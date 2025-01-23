using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Gazeus.DesafioMatch3.Models;

namespace Gazeus.DesafioMatch3
{
    public class TypeData : MonoBehaviour
    {
        public TileType tileType;

    }
    public enum TileType:int
    {
        Blue,
        Green,
        Red,
        Pink,
        Orange,
        Yellow,
        Purple
    }
}
