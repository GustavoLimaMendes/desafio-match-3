using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Gazeus.DesafioMatch3
{
    public class MenuController : MonoBehaviour
    {
       
        public void StartGame()
        {
            // Carrega a cena do jogo 
            SceneManager.LoadScene("Gameplay");
        }
    
    }
}
