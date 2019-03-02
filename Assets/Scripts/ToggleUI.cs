using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleUI : MonoBehaviour
{

    public Rotate rotate;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnClicked()
    {
        rotate.rotate = !rotate.rotate;
    }

}
