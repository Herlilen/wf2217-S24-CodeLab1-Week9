using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu
    (
    fileName = "New Direction",
        menuName = "New Direction",
            order = 0)
]

public class DirectionScriptableObject : ScriptableObject
{
    public string directionName;
    public AudioClip directionAudio;
    public Material directionSkybox;
    
}

