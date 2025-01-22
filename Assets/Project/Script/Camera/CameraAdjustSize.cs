using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gazeus.DesafioMatch3
{
    public class CameraAdjustSize : MonoBehaviour
    {

        [SerializeField] Canvas canvas;

        void Start()
        {
            Vector3 rectPos = canvas.transform.position;

            Camera camera = GetComponent<Camera>();

            float targetAspect = 9f / 16f;  // Aspect ratio desejado (por exemplo, 16:9)

            camera.transform.position = new Vector3(rectPos.x, rectPos.y, -10f);

            float windowAspect = (float)Screen.width / (float)Screen.height;
            float scaleHeight = windowAspect / targetAspect;

            camera.orthographicSize = rectPos.y;

        }
    }
}
