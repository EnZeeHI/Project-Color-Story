﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ellieBeStalking : MonoBehaviour
{
    public Transform target;
    public float stoppingDistance;
    public float speed;


    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, target.position) > stoppingDistance)
        {
            Vector3 targetDir = target.position - transform.position;

            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, 5, 0.0f);
            transform.rotation = Quaternion.LookRotation(newDir);
        }
    }
}
