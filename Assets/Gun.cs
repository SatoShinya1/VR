using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject m_bulletPrefab = null;
    [SerializeField] private Transform m_muzzlePos = null;
    
    [SerializeField] private Rigidbody rb;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShootAmmo()
	{
        //弾のプレハブか銃口位置が設定されていなければ処理を行わず帰る。ついでに煽る。
        if(m_bulletPrefab == null ||
            m_muzzlePos == null)
		{
            Debug.Log(" Inspector の設定が間違ってるでww m9(^Д^)ﾌﾟｷﾞｬｰ ");
            return;
		}

        //弾を生成する。
        GameObject bulletObj = Instantiate(m_bulletPrefab);

        rb = bulletObj.GetComponent<Rigidbody>();

        //弾の位置を、銃口の位置と同一にする。
        bulletObj.transform.position = m_muzzlePos.position;

        //弾の向きを、銃口の向きと同一にする。
        bulletObj.transform.rotation = m_muzzlePos.rotation;

        rb.AddForce(transform.forward*100.0f,ForceMode.Force);//前に飛ばす

    }

    public void Active(){
        ShootAmmo();
    }
}
