using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    private float playerDir;
    public DirectionScriptableObject[] currentDir;
    public AudioSource _audioSource;
    private Material _material;

    // Update is called once per frame
    void Update()
    {
        // get player looking angle
        Vector3 currentAngles = player.transform.rotation.eulerAngles;
        float playerDir = currentAngles.y;
        Debug.Log(RenderSettings.skybox);
        
        // set cases for player angle
        if (playerDir >= 0 && playerDir < 90)
        {
            //_audioSource.PlayOneShot(currentDir[0].directionAudio);
            RenderSettings.skybox = currentDir[0].directionSkybox;
        }
        if (playerDir >= 90 && playerDir < 180)
        {
            //_audioSource.PlayOneShot(currentDir[1].directionAudio);
            RenderSettings.skybox = currentDir[1].directionSkybox;
        }
        if (playerDir >= 180 && playerDir < 270)
        {
           // _audioSource.PlayOneShot(currentDir[2].directionAudio);
            RenderSettings.skybox = currentDir[2].directionSkybox;
        }
        if (playerDir >= 270 && playerDir < 360)
        {
            //_audioSource.PlayOneShot(currentDir[3].directionAudio);
            RenderSettings.skybox = currentDir[3].directionSkybox;
        }
    }
}
