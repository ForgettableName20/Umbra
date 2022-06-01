using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceObject : MonoBehaviour
{
    int m_IndexNumber;

    public void PlaceObj()
    {
        m_IndexNumber = 0;
        transform.SetSiblingIndex(m_IndexNumber);
    }

    
}
