using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;

    private const float Timer = 0.5f;
    private float currentTime = 0.5f;
    private bool canShoot = true;

    private void Update()
    {
        TimerMethod();
        Shoot();
    }

    private void TimerMethod()
    {
        if (!canShoot)
        {
            currentTime -= Time.deltaTime;

            if (currentTime < 0)
            {
                canShoot = true;
                currentTime = Timer;
            }
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            canShoot = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1) && canShoot)
        {
            GameObject bullet2 = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);

            bullet2.transform.SetParent(bulletTrash);

            canShoot = false;
        }
    }
}
