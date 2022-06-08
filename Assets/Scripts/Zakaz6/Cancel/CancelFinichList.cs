using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelFinichList : MonoBehaviour
{
    public GameObject FinichList;

    public void ClotheFinichList()
    {
        FinichList.SetActive(false);
    }
}
