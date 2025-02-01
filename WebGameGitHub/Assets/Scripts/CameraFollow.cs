using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //public static CameraFollow instance;
   
    private GameObject player; 
    private Vector3 offset;

    private bool playerFollow;
    public bool odinRazBool;
    void Start()
    {
        playerFollow = false;
        /*player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;*/

        Invoke("PlayerSearch", 1f);
    }

    void LateUpdate()
    {

        if (playerFollow == true)
        {
            //Debug.Log("� ������� ��� ��������");
            transform.position = player.transform.position + offset;
        }
        
    }

    public void PlayerSearch()
    {
        Debug.Log("����� � ������� ������ ������");
        player = GameObject.FindWithTag("Player");
        offset = transform.position - player.transform.position;
        playerFollow = true;
        Debug.Log("����� � ������� ������ ������");
        
    }


}
