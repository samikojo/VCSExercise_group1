using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
        [SerializeField]
        private float speed = 0;
		private float rotSpeed = 5f;
		private float multiplier = 20f;


		void Update()
		{
			/* WASD movement start */

			if (Input.GetAxisRaw("Horizontal") > 0)
			{
				Vector3 temp = new Vector3(0.1f,0,0);
				transform.position += temp;
			}
			if (Input.GetAxisRaw("Horizontal") < 0)
			{
				Vector3 temp = new Vector3(-0.1f,0,0);
				transform.position += temp;
			}
			if (Input.GetAxisRaw("Vertical") > 0)
			{
				Vector3 temp = new Vector3(0,0,0.1f);
				transform.position += temp;
			}
			if (Input.GetAxisRaw("Vertical") < 0)
			{
				Vector3 temp = new Vector3(0,0,-0.1f);
				transform.position += temp; 
			}
            if(Input.GetButtonDown("Jump"))
            {
                if(transform.position.y < .55)
                {
                    GetComponent<Rigidbody>().velocity = Vector3.up * speed;
                }
            }

			/* WASD movement end */

			//Rotation
			if (Input.GetKey(KeyCode.Q)) {
				PingPongRotation(-multiplier);
			}

			if (Input.GetKey(KeyCode.E)) {
				PingPongRotation(multiplier);
			}
		}

		void PingPongRotation(float multiplier) {
			transform.localEulerAngles += new Vector3(0, multiplier * Time.deltaTime * rotSpeed, 0);
		}

	}
}
