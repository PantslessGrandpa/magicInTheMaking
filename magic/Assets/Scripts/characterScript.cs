﻿using UnityEngine;
using System.Collections;

public class characterScript : MonoBehaviour {
	public Sprite facingUp;
	public Sprite facingDown;
	public Sprite facingRight;
	public Sprite facingLeft;
	public Sprite movingUp;
	public Sprite movingDown;
	public Sprite movingRight;
	public Sprite movingLeft;
	private Animator animator;
	private SpriteRenderer spriteRenderer;
	private Animation animation;
	// Use this for initialization

	void Start () {
		animator = GetComponent<Animator>();
		animation = GetComponent<Animation>();
		spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (mainObjectController.isStill) {
			animator.SetBool ("idle", true);
		} else if (!mainObjectController.isStill) {
			animator.SetBool("idle", false);
		}
		if (mainObjectController.whichWay == 1 && !mainObjectController.isStill && !weaponBox.haveAttacked) {
		//	Animation.Play("WalkingUp");
			animator.SetInteger("walkingDirection", 1);
		}
		if (mainObjectController.whichWay == 2 && !mainObjectController.isStill && !weaponBox.haveAttacked) {
		//	Animation.Play("WalkingDown");
			animator.SetInteger("walkingDirection", 2);
		}
		if (mainObjectController.whichWay == 3 && !mainObjectController.isStill && !weaponBox.haveAttacked) {
		//	Animation.Play();
			animator.SetInteger("walkingDirection", 3);
		}
		if (mainObjectController.whichWay == 4 && !mainObjectController.isStill && !weaponBox.haveAttacked) {
		//	Animation.Play();
			animator.SetInteger("walkingDirection", 4);
		}
		//sets the correct sprite for the direction the character is facing while not moving
		if (mainObjectController.isStill && mainObjectController.whichWay == 1 && !weaponBox.haveAttacked) {
			animator.SetInteger("facingDirection", 1);
		}
		if (mainObjectController.isStill && mainObjectController.whichWay == 2 && !weaponBox.haveAttacked) {
			animator.SetInteger("facingDirection", 2);
		}
		if (mainObjectController.isStill && mainObjectController.whichWay == 3 && !weaponBox.haveAttacked) {
			animator.SetInteger("facingDirection", 3);
		}
		if (mainObjectController.isStill && mainObjectController.whichWay == 4 && !weaponBox.haveAttacked) {
			animator.SetInteger("facingDirection", 4);
		}
	}
}
