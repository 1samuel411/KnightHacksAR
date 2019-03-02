using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection : DefaultTrackableEventHandler
{

    public GameObject ui;

    private void Awake()
    {
    }

    protected override void OnTrackingFound()
    {
        base.OnTrackingFound();
        ui.SetActive(true);
    }

    protected override void OnTrackingLost()
    {
        base.OnTrackingLost();
        ui.SetActive(false);
    }
}
