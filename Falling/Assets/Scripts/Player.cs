using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Time.timeScale += Time.fixedDeltaTime * 0.01f;
        transform.rotation *= Quaternion.Euler(0, 0, Time.deltaTime * 7f);
        rigid.velocity += transform.rotation * (Input.GetAxisRaw("Horizontal") * Vector3.right * 10f) * Time.deltaTime;
        rigid.velocity += transform.rotation * (Input.GetAxisRaw("Vertical") * Vector3.up * 10f) * Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Time.timeScale = 1f;
        if (other.gameObject.tag == "Obstacle")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

}
