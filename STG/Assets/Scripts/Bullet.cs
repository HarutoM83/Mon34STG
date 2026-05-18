using UnityEngine;

public class Bullet : MonoBehaviour
{
    Shot b;
    [SerializeField] float bulletspeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        b = GetComponent<Shot>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerBullet();
    }

    void PlayerBullet()
    {
        transform.Translate(Vector3.down * bulletspeed * Time.deltaTime);
    }

}
