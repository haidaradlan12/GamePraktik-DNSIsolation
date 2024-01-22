using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ItemDrop : MonoBehaviour, IDropHandler
{
    public int b , c;
    private int d;
    public GameObject DaunLembaran1, DaunLembaran2, DaunLembaran3, DaunLembaran4, DaunTumpuk1, DaunTumpuk2, DaunTumpuk3, DaunTumpuk4; // tambahan
    public GameObject DaunTumpukFull, LumpangKosong, Lumpangisi;
    public GameObject Sendok1, Sendok2, Sendok3, Garam1, Garam2, Garam3;
    public GameObject aquadest1, aquadest2, airaqua1, airaqua2, aquadesanim1, aquadesanim2;
    public GameObject BekerglassAquades, AirLumpang, lumpangisifull;
    public GameObject Penghalang1, Penghalang2, Penghalang3, Penghalang4, Penghalang5, Penghalang6;
    public GameObject Alu, DepanLumpang, LumpangIsiLebur, aluanimation;
    public GameObject paperkotak, paper, paperekstrak, airekstrak;
    public GameObject Inkubbuka, Incubon, Incuboff, Incuboff2, glassbekerekstrak, tabungreaksi;
    public GameObject airekstraktabung, airekstrakdandeterjen, airektrakdeterjennanas, glassdeterjen, glassnanas;
    public GameObject etanol, benangputih, airekstrakakhir;
    public GameObject T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11;
    int coun = 0;
    public void OnDrop(PointerEventData eventData)
    { 
        if (eventData.pointerDrag != null)
        {
            Debug.Log(coun);
            //eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //ubahan
            coun = coun + 1;
            if (b == 1 && c == 0)
            {
                if (coun == 1)
                {
                    DaunLembaran1.SetActive(false);
                    DaunTumpuk1.SetActive(true);
                }
                else if (coun == 2)
                {
                    DaunLembaran2.SetActive(false);
                    DaunTumpuk2.SetActive(true);
                }
                else if (coun == 3)
                {
                    DaunLembaran3.SetActive(false);
                    DaunTumpuk3.SetActive(true);
                }
                else if (coun == 4)
                {
                    DaunLembaran4.SetActive(false);
                    DaunTumpuk4.SetActive(true);

                    T1.SetActive(false);
                    T2.SetActive(true);

                    Penghalang1.SetActive(false);
                    Penghalang2.SetActive(false);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(true);
                    Penghalang5.SetActive(true);
                    Penghalang6.SetActive(true);
                }
            }
            else if (b == 2 && c == 1)
            {
                Penghalang1.SetActive(true);
                Penghalang2.SetActive(false);
                Penghalang3.SetActive(true);
                Penghalang4.SetActive(true);
                Penghalang5.SetActive(true);
                Penghalang6.SetActive(true);

                T2.SetActive(false);
                T3.SetActive(true);

                LumpangKosong.SetActive(false);
                DaunTumpukFull.SetActive(false);
                Lumpangisi.SetActive(true);
            }
            else if (b == 3 && c == 2)
            {
                if (coun == 1)
                {
                    Sendok1.SetActive(false);
                    Garam1.SetActive(true);
                }
                else if (coun == 2)
                {
                    Sendok2.SetActive(false);
                    Garam2.SetActive(true);

                    T3.SetActive(false);
                    T4.SetActive(true);

                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(false);
                    Penghalang3.SetActive(false);
                    Penghalang4.SetActive(true);
                    Penghalang5.SetActive(true);
                    Penghalang6.SetActive(true);
                }
                else if (coun == 3)
                {
                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(false);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(false);
                    Penghalang5.SetActive(true);
                    Penghalang6.SetActive(true);

                    BekerglassAquades.SetActive(false);
                    AirLumpang.SetActive(true);
                    DepanLumpang.SetActive(true);
                    lumpangisifull.SetActive(true);

                    T4.SetActive(false);
                    T5.SetActive(true);
                }
            }
            else if (b == 4 && c == 3)
            {
                if (coun == 1)
                {
                    aquadest1.SetActive(false);
                    airaqua1.SetActive(true);
                    aquadesanim1.SetActive(true);
                }
                else if (coun == 2)
                {
                    aquadest2.SetActive(false);
                    airaqua2.SetActive(true);
                    aquadesanim2.SetActive(true);

                    

                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(false);
                    Penghalang3.SetActive(false);
                    Penghalang4.SetActive(true);
                    Penghalang5.SetActive(true);
                    Penghalang6.SetActive(true);
                    d = 1;
                }
            }
            else if (b == 5 && c == 4)
            {
                Lumpangisi.SetActive(false);
                Garam1.SetActive(false);
                Garam2.SetActive(false);
                AirLumpang.SetActive(false);
                Alu.SetActive(false);
                aluanimation.SetActive(true);
                LumpangIsiLebur.SetActive(true);

                T5.SetActive(false);
                T6.SetActive(true);
            }
            else if (b == 6 && c == 5)
            {
                if (coun == 1)
                {
                    paper.SetActive(true);
                    paperkotak.SetActive(false);
                    DepanLumpang.SetActive(false);
                }
                else if (coun == 2)
                {
                    paperekstrak.SetActive(true);
                    airekstrak.SetActive(true);
                    LumpangIsiLebur.SetActive(false);

                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(true);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(false);
                    Penghalang5.SetActive(false);
                    Penghalang6.SetActive(true);

                    T6.SetActive(false);
                    T7.SetActive(true);
                }
            }
            else if (b == 7 && c == 6)
            {
                if (coun == 1)
                {
                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(true);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(false);
                    Penghalang5.SetActive(true);
                    Penghalang6.SetActive(false);

                    Inkubbuka.SetActive(false);
                    Incubon.SetActive(true);
                    Incuboff.SetActive(true);
                    glassbekerekstrak.SetActive(false);

                    
                }
                else if (coun == 2)
                {
                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(true);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(true);
                    Penghalang5.SetActive(false);
                    Penghalang6.SetActive(false);

                    Inkubbuka.SetActive(false);
                    Incubon.SetActive(true);
                    Incuboff2.SetActive(true);
                    tabungreaksi.SetActive(false);

                    
                }
            }
            else if (b == 8 && c == 7)
            {
                if (coun == 1)
                {
                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(true);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(false);
                    Penghalang5.SetActive(true);
                    Penghalang6.SetActive(false);

                    airekstraktabung.SetActive(true);
                    glassbekerekstrak.SetActive(false);

                    T7.SetActive(false);
                    T8.SetActive(true);
                }
                else if (coun == 2)
                {
                    airekstraktabung.SetActive(false);
                    airekstrakdandeterjen.SetActive(true);
                    glassdeterjen.SetActive(false);

                    T8.SetActive(false);
                    T9.SetActive(true);
                }
                else if (coun == 3)
                {
                    Penghalang1.SetActive(true);
                    Penghalang2.SetActive(true);
                    Penghalang3.SetActive(true);
                    Penghalang4.SetActive(true);
                    Penghalang5.SetActive(false);
                    Penghalang6.SetActive(false);

                    airekstrakdandeterjen.SetActive(false);
                    airektrakdeterjennanas.SetActive(true);
                    glassnanas.SetActive(false);

                    T9.SetActive(false);
                    T10.SetActive(true);
                }
            }
            else if (b == 9 && c == 8)
            {
                Penghalang1.SetActive(true);
                Penghalang2.SetActive(true);
                Penghalang3.SetActive(true);
                Penghalang4.SetActive(true);
                Penghalang5.SetActive(true);
                Penghalang6.SetActive(true);

                etanol.SetActive(false);
                benangputih.SetActive(true);
                airektrakdeterjennanas.SetActive(false);
                airekstrakakhir.SetActive(true);

                T10.SetActive(false);
                T11.SetActive(true);
            }
        }
    }
    

}
