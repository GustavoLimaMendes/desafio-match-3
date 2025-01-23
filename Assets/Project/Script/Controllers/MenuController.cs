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
            SceneManager.LoadScene("Gameplay");
        }
        public void ExitGame()
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
