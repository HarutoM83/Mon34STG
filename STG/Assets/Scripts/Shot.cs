using UnityEngine;

public class Shot : MonoBehaviour
{

    public GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BulletShot()
    {
        Vector3 bulletPosition = new Vector3(0, 0, 0);
        Quaternion bulletRotation = Quaternion.Euler(0, 0, 90); // Šp“x‚ð•ÏŠ·
        Instantiate(bullet, this.transform.position, bulletRotation);
    }
}
