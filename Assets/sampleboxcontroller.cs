using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sampleboxcontroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {

        //障害物に衝突した場合
        if (other.gameObject.tag == "CarTag")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }

        //コインに衝突した場合（追加）
        if (other.gameObject.tag == "CoinTag")
        {
            //接触したコインのオブジェクトを破棄（追加）
            Destroy(other.gameObject);
        }
    }
}
