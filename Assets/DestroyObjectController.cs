using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectController : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    //トリガーモードで他のオブジェクトと接触した場合の処理
    void OnTriggerEnter(Collider other)
    {

        //後ろに来たオブジェクトを破棄
        Destroy(other.gameObject);

    }

}
