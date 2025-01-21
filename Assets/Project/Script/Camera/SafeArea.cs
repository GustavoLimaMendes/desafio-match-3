using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gazeus.DesafioMatch3
{
    public class SafeArea : MonoBehaviour
    {
        RectTransform rectTransform;

        void Start()
        {
            rectTransform = GetComponent<RectTransform>();
            ApplySafeArea();
        }

        void ApplySafeArea()
        {
            Rect safeArea = Screen.safeArea;
            float width = safeArea.width / Screen.width;
            float height = safeArea.height / Screen.height;

            rectTransform.anchorMin = new Vector2(safeArea.x / Screen.width, safeArea.y / Screen.height);
            rectTransform.anchorMax = new Vector2((safeArea.x + safeArea.width) / Screen.width, (safeArea.y + safeArea.height) / Screen.height);
        }
    }
}
