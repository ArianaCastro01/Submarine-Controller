using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    float speed = 25.0F;
    public float speedMod = 0;
    public float rotationSpeed = 50.0F;
    private int count;
    public Text countText;
    public Text winText;
    float time = 3f;

     private void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        count = 0;
         SetCountText();
        winText.text = "";
    }

    private void Update()
    {
        float translation = Input.GetAxis("Jump") * speed;
        //float translation = Input.GetAxis("Vertical") * speed;
        float yawRot = Input.GetAxis("Horizontal") * rotationSpeed;
        float pitchRot = Input.GetAxis("Vertical") * rotationSpeed;
        translation *= Time.deltaTime;
        rb.AddForce(this.transform.forward * translation * speedMod);
        rb.AddTorque(this.transform.up * yawRot * 0.15f);
        rb.AddTorque(this.transform.right * pitchRot * 0.01f);
        //AnalogSpeedConverter.ShowSpeed(rb.velocity.magnitude, 0, 200);

    }

      void OnTriggerEnter(Collider other)
      {
          if (other.CompareTag("Pick Up"))
          {
              other.gameObject.SetActive(false);
              count = count + 1;
              SetCountText();
          }
      } 

    void SetCountText ()
    {
        countText.text = count.ToString();
        if (count >= 4)
        {
            winText.text = "You cleaned the ocean!";
            Invoke("Hide", time);
        }
    }

    void Hide()
    {
        Destroy(winText);
    }
}
