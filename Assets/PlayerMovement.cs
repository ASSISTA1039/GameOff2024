// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class PlayerMovement : MonoBehaviour {
// 	public float moveSpeed;

// 	private bool isMoving;

// 	private Vector2 input;

// 	private void Update() {
// 		if (!isMoving) {
// 			input.x = input.GetAxisRaw("Horizontal");
// 			input.y = input.GetAxisRaw("Vertical");

// 			if (input != Vector2.zero) {
// 				var targetPos = transform.position;

// 				targetPos.x += input.x;
// 				targetPos.y += input.y;

// 				StartCorountine(Move(targetPos));
// 			}

// 		}
// 	}

// 	IEnumerator Move(Vector3 targetPos) {
// 		isMoving = true;

// 		while ((targetPos - transform.position).sqrMagnitude > Mathf.Epsilon) {
// 			targetPos.position = Vector3.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
// 			yield return null;
// 		}
// 		transform.position = targetPos;

// 		isMoving = false;
// 	}

	
// }
