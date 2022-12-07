using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayEndCanvasController : MonoBehaviour
{
    public GameObject visual;
    // Start is called before the first frame update
    void Start()
    {
        Timer.timerFinished += ShowVisual;
        visual.SetActive(false);
    }

    public void ShowVisual()
    {
        visual.SetActive(true);

    }

    private void OnDestroy()
    {
        Timer.timerFinished -= ShowVisual;
    }
}
