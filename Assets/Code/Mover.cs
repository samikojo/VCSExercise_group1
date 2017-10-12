using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
        [SerializeField]
        private float speed = 0;
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
		}

	}
}
