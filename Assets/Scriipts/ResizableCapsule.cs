using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ResizableCapsule : TransformationObject
{
    private void Update()
    {
        Resize();
        
        if (ShouldChangeResizeSpeedDirection())
        {
            ChangeSpeedResizeDirection();
        }
    }
}
