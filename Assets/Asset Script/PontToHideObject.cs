using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PontToHideObject : MonoBehaviour, IPointerDownHandler
{
    public GameObject Hilang1, Hilang2, Hilang3;
    public void OnPointerDown(PointerEventData eventData)
    {
        Hilang1.SetActive(false);
        Hilang2.SetActive(false);
        Hilang3.SetActive(false);
    }
}
