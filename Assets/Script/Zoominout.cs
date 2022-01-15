using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zoominout : MonoBehaviour
{
    public GameObject Zoom, Karakterawal;

    public void ButtonZoom()
    {
        Zoom.SetActive(true);
        Karakterawal.SetActive(false);
    }
    public void Close()
    {
        Zoom.SetActive(false);
        Karakterawal.SetActive(true);
    }

}