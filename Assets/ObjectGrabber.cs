using System.Collections;
using System.Collections.Generic;
using Cpooties;
using UnityEngine;

public class ObjectGrabber : MonoBehaviour
{
    [SerializeField] private LayerMask grabLayers;
    [SerializeField] private float maxGrabDistance = 100f;
    private Transform rightHand, leftHand;
    
    // Start is called before the first frame update
    void Awake()
    {
        rightHand = GameObject.Find("RightController").transform;
        leftHand = GameObject.Find("LeftController").transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastFromHand(leftHand);
        RaycastFromHand(rightHand);
    }

    private void RaycastFromHand(Transform hand)
    {
        if (Physics.Raycast(hand.position, hand.forward, maxGrabDistance, grabLayers, QueryTriggerInteraction.Ignore))
        {
            
        }
    }
}
