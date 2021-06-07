using UnityEngine;

public class InputMapper : MonoBehaviour 
{
	Animator animator;

	void Start() {
		animator = GetComponent<Animator>();
	}
	
	void Update() {
		float x = Input.GetAxisRaw("Horizontal");
		animator.SetFloat("axisHorizontal", x);
	}
}
