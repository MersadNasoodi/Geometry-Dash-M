using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSSet : MonoBehaviour
{
    private void Start()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 61;
    }
}
