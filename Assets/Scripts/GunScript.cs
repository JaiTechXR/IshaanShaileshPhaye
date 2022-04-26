using UnityEngine;

public class GunScript : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public AudioClip shootSound;

    public Camera cam;

    private void Start()
    {
        Cursor.visible = false;
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot();
            AudioSource.PlayClipAtPoint(shootSound, transform.position);
        }
    }

    void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
        }
    }
    
}
