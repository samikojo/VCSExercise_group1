using UnityEngine;

namespace TAMK.VCSExample
{
	public class Mover : MonoBehaviour
	{
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

			/* WASD movement end */
		}
	}
}
