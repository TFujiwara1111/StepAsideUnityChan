using System.Collections;
using UnityEngine;

public class DestroyController : MonoBehaviour
{
    void Update()
    {
        //画面外に出たら、破棄する
        if (transform.position.z < Camera.main.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
