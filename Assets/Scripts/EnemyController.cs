using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public int damage = 1;
    public int speed = 2;
    private Cam_Shake shake;
    public GameObject effect;

    private void Start()
    {
        shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<Cam_Shake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -9.5f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shake.CamShake();
            other.GetComponent<PlayerController>().health -= damage;
            Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(gameObject);
            if(other.GetComponent<PlayerController>().health == 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
        //if(other.CompareTag("Bound"))
        //{
        //    Destroy(gameObject);
        //}

    }
}
