using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class cliktoshow : MonoBehaviour, IPointerDownHandler
{
    public GameObject Show1, Show2, Show3;
    public void OnPointerDown(PointerEventData eventData)
    {
        Show1.SetActive(true);
        Show2.SetActive(true);
        Show3.SetActive(true);
    }
}
