﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            this.transform.position = Input.mousePosition;
            DataCollector.RegisterEntityKillWithTime(this);
        }
    }
}
