using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDropGame2 : MonoBehaviour, IDropHandler
{
    public int b;
    int coun = 0;
    
    public GameObject suntikanbiru, animasisuntikanbiru;
    public GameObject suntikanmerah, animasisuntikanmerah, animasisuntikmerah2;
    public GameObject antigentikusanimasi;
    public GameObject pipetanimasi, pipet, antigenkangkeranimasi;
    public GameObject pipet2, pipetanimasi2, pipetanimasi3, hilangkanantibodi, adakansebelumnya;
    public GameObject aktifkan;
    public GameObject T1, T2, T3, T4, T5, T6, T7, T8;
    public GameObject Next1, Next2, selesai;

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Debug.Log(coun);
            coun = coun + 1;
            if (b == 1)
            {

                if (coun == 1)
                {
                    suntikanbiru.SetActive(false);
                    animasisuntikanbiru.SetActive(true);
                    T1.SetActive(false);
                    T2.SetActive(true);
                    Next1.SetActive(true);
                }
                else if (coun == 2)
                {
                    suntikanmerah.SetActive(false);
                    animasisuntikanmerah.SetActive(true);
                }
            }
            else if (b == 2)
            {
                T3.SetActive(false);
                T4.SetActive(true);
                animasisuntikanmerah.SetActive(false);
                animasisuntikmerah2.SetActive(true);
                antigentikusanimasi.SetActive(true);
            }
            else if (b == 3)
            {
                T4.SetActive(false);
                T5.SetActive(true);

                pipetanimasi.SetActive(true);
                pipet.SetActive(false);
                antigenkangkeranimasi.SetActive(true);
                Next2.SetActive(true);
            }
            else if (b==4)
            {
                pipet2.SetActive(false);
                pipetanimasi2.SetActive(true);
                hilangkanantibodi.SetActive(false);
                adakansebelumnya.SetActive(true);
            }
            else if (b == 5)
            {
                T7.SetActive(false);
                T8.SetActive(true);
                selesai.SetActive(true);
                pipetanimasi2.SetActive(false);
                pipetanimasi3.SetActive(true);
                aktifkan.SetActive(true);
            }
        }
    }
}
