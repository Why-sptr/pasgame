using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] private bool autoFindPlayer = true;
    [SerializeField] private GameObject playerTarget;

    [SerializeField] private bool enableSmooth = true;
    [SerializeField] private float smoothTime = 0.2f;

    [Space]
    [SerializeField] private Vector3 offset;

    Vector3 smoothVelocity;
    private void Awake()
    {
        if (autoFindPlayer)
            playerTarget = GameObject.FindGameObjectWithTag("Player");
        
    }

    private void Update()
    {
        Vector3 finalPosCam = (playerTarget.transform.position + offset);
        if (enableSmooth)
            transform.position = Vector3.SmoothDamp(transform.position, finalPosCam, ref smoothVelocity, smoothTime);
        else
            transform.position = finalPosCam;
    }
}
